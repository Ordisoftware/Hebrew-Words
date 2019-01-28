using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Novacode;
using System.IO;
using System.Data;
using System.Drawing;
using System.Reflection;

namespace Novacode
{
    class Program
    {
        /* 
         * Place holder for the executing assembly, 
         * we need this to access embedded resources.
         */
        static Assembly g_assembly;
        
        // Place holder for a document.
        static DocX g_document;

        static void Main(string[] args)
        {
            // Store a global reference to the executing assembly.
            g_assembly = Assembly.GetExecutingAssembly();

            // Try to load the template 'InvoiceTemplate.docx'.
            try
            {
                // Store a global reference to the loaded document.
                g_document = DocX.Load(@"InvoiceTemplate.docx");

                /*
                 * The template 'InvoiceTemplate.docx' exists, 
                 * so lets use it to create an invoice for a factitious company
                 * called "The Happy Builder" and store a global reference it.
                 */
                g_document = CreateInvoiceFromTemplate(DocX.Load(@"InvoiceTemplate.docx"));

                // Save all changes made to this template as Invoice_The_Happy_Builder.docx (We don't want to replace InvoiceTemplate.docx).
                g_document.SaveAs("Invoice_The_Happy_Builder.docx");
            }

            // The template 'InvoiceTemplate.docx' does not exist, so create it.
            catch (FileNotFoundException)
            {
                // Create a store a global reference to the template 'InvoiceTemplate.docx'.
                g_document = CreateInvoiceTemplate();

                // Save the template 'InvoiceTemplate.docx'.
                g_document.Save();
            }
        }

        // Create an invoice for a factitious company called "The Happy Builder".
        private static DocX CreateInvoiceFromTemplate(DocX template)
        {
            #region Logo
            // A quick glance at the template shows us that the logo Paragraph is in row zero cell 1.
            Paragraph logo_paragraph = template.Tables[0].Rows[0].Cells[1].Paragraph;
            // Remove the template Picture that is in this Paragraph.
            logo_paragraph.Pictures[0].Remove();

            // Add the Happy Builders logo to this document.
            Novacode.Image logo = template.AddImage(g_assembly.GetManifestResourceStream("Novacode.Resources.logo_the_happy_builder.png"));
            
            // Insert the Happy Builders logo into this Paragraph.
            Picture logo_picture = logo_paragraph.InsertPicture(logo.Id);
            #endregion

            #region Set CustomProperty values
            // Set the value of the custom property 'company_name'.
            template.AddCustomProperty(new CustomProperty("company_name", "The Happy Builder"));

            // Set the value of the custom property 'company_slogan'.
            template.AddCustomProperty(new CustomProperty("company_slogan", "No job too small"));

            // Set the value of the custom properties 'hired_company_address_line_one', 'hired_company_address_line_two' and 'hired_company_address_line_three'.
            template.AddCustomProperty(new CustomProperty("hired_company_address_line_one", "The Crooked House,"));
            template.AddCustomProperty(new CustomProperty("hired_company_address_line_two", "Dublin,"));
            template.AddCustomProperty(new CustomProperty("hired_company_address_line_three", "12345"));

            // Set the value of the custom property 'invoice_date'.
            template.AddCustomProperty(new CustomProperty("invoice_date", DateTime.Today.Date.ToString("d")));

            // Set the value of the custom property 'invoice_number'.
            template.AddCustomProperty(new CustomProperty("invoice_number", 1));

            // Set the value of the custom property 'hired_company_details_line_one' and 'hired_company_details_line_two'.
            template.AddCustomProperty(new CustomProperty("hired_company_details_line_one", "Business Street, Dublin, 12345"));
            template.AddCustomProperty(new CustomProperty("hired_company_details_line_two", "Phone: 012-345-6789, Fax: 012-345-6789, e-mail: support@thehappybuilder.com"));    
            #endregion

            /* 
             * InvoiceTemplate.docx contains a blank Table, 
             * we want to replace this with a new Table that
             * contains all of our invoice data.
             */
            Table t = template.Tables[1];
            Table invoice_table = CreateAndInsertInvoiceTableAfter(t, ref template);
            t.Remove();

            // Return the template now that it has been modified to hold all of our custom data.
            return template;
        }

        // Create an invoice template.
        private static DocX CreateInvoiceTemplate()
        {
            // Create a new document.
            DocX document = DocX.Create(@"InvoiceTemplate.docx");

            // Create a table for layout purposes (This table will be invisible).
            Table layout_table = document.InsertTable(2, 2);
            layout_table.Design = TableDesign.TableNormal;
            layout_table.AutoFit = AutoFit.Window;

            // Dark formatting
            Formatting dark_formatting = new Formatting();
            dark_formatting.Bold = true;
            dark_formatting.Size = 12;
            dark_formatting.FontColor = Color.FromArgb(31, 73, 125);

            // Light formatting
            Formatting light_formatting = new Formatting();
            light_formatting.Italic = true;
            light_formatting.Size = 11;
            light_formatting.FontColor = Color.FromArgb(79, 129, 189);

            #region Company Name
            // Get the upper left Paragraph in the layout_table.
            Paragraph upper_left_paragraph = layout_table.Rows[0].Cells[0].Paragraph;

            // Create a custom property called company_name
            CustomProperty company_name = new CustomProperty("company_name", "Company Name");

            // Insert a field of type doc property (This will display the custom property 'company_name')
            layout_table.Rows[0].Cells[0].Paragraph.InsertDocProperty(company_name, dark_formatting);

            // Force the next text insert to be on a new line.
            upper_left_paragraph.InsertText("\n", false);
            #endregion

            #region Company Slogan
            // Create a custom property called company_slogan
            CustomProperty company_slogan = new CustomProperty("company_slogan", "Company slogan goes here.");

            // Insert a field of type doc property (This will display the custom property 'company_slogan')
            upper_left_paragraph.InsertDocProperty(company_slogan, light_formatting);
            #endregion

            #region Company Logo
            // Get the upper right Paragraph in the layout_table.
            Paragraph upper_right_paragraph = layout_table.Rows[0].Cells[1].Paragraph;

            // Add a template logo image to this document.
            Novacode.Image logo = document.AddImage(g_assembly.GetManifestResourceStream("Novacode.Resources.logo_template.png"));
            
            // Insert this template logo into the upper right Paragraph.
            Picture picture_logo = upper_right_paragraph.InsertPicture(logo.Id, "", "");
            
            upper_right_paragraph.Alignment = Alignment.right;
            #endregion

            // Custom properties cannot contain newlines, so the company address must be split into 3 custom properties.
            #region Hired Company Address
            // Create a custom property called company_address_line_one
            CustomProperty hired_company_address_line_one = new CustomProperty("hired_company_address_line_one", "Street Address,");

            // Get the lower left Paragraph in the layout_table. 
            Paragraph lower_left_paragraph = layout_table.Rows[1].Cells[0].Paragraph;
            lower_left_paragraph.InsertText("TO:\n", false, dark_formatting);

            // Insert a field of type doc property (This will display the custom property 'hired_company_address_line_one')
            lower_left_paragraph.InsertDocProperty(hired_company_address_line_one, light_formatting);

            // Force the next text insert to be on a new line.
            lower_left_paragraph.InsertText("\n", false);

            // Create a custom property called company_address_line_two
            CustomProperty hired_company_address_line_two = new CustomProperty("hired_company_address_line_two", "City,");

            // Insert a field of type doc property (This will display the custom property 'hired_company_address_line_two')
            lower_left_paragraph.InsertDocProperty(hired_company_address_line_two, light_formatting);

            // Force the next text insert to be on a new line.
            lower_left_paragraph.InsertText("\n", false);

            // Create a custom property called company_address_line_two
            CustomProperty hired_company_address_line_three = new CustomProperty("hired_company_address_line_three", "Zip Code");

            // Insert a field of type doc property (This will display the custom property 'hired_company_address_line_three')
            lower_left_paragraph.InsertDocProperty(hired_company_address_line_three, light_formatting);
            #endregion

            #region Date & Invoice number
            // Get the lower right Paragraph from the layout table.
            Paragraph lower_right_paragraph = layout_table.Rows[1].Cells[1].Paragraph;

            CustomProperty invoice_date = new CustomProperty("invoice_date", DateTime.Today.Date.ToString("d"));
            lower_right_paragraph.InsertText("Date: ", false, dark_formatting);
            lower_right_paragraph.InsertDocProperty(invoice_date, light_formatting);

            CustomProperty invoice_number = new CustomProperty("invoice_number", 1);
            lower_right_paragraph.InsertText("\nInvoice: ", false, dark_formatting);
            lower_right_paragraph.InsertText("#", false, light_formatting);
            lower_right_paragraph.InsertDocProperty(invoice_number, light_formatting);

            lower_right_paragraph.Alignment = Alignment.right;
            #endregion

            // Insert an empty Paragraph between two Tables, so that they do not touch.
            document.InsertParagraph(string.Empty, false);

            // This table will hold all of the invoice data.
            Table invoice_table = document.InsertTable(4, 4);
            invoice_table.Design = TableDesign.LightShadingAccent1;
            invoice_table.Alignment = Alignment.center;

            // A nice thank you Paragraph.
            Paragraph thankyou = document.InsertParagraph("\nThank you for your business, we hope to work with you again soon.", false, dark_formatting);
            thankyou.Alignment = Alignment.center;

            #region Hired company details
            CustomProperty hired_company_details_line_one = new CustomProperty("hired_company_details_line_one", "Street Address, City, ZIP Code");
            CustomProperty hired_company_details_line_two = new CustomProperty("hired_company_details_line_two", "Phone: 000-000-0000, Fax: 000-000-0000, e-mail: support@companyname.com");

            Paragraph companyDetails = document.InsertParagraph(string.Empty, false);
            companyDetails.InsertDocProperty(hired_company_details_line_one, light_formatting);
            companyDetails.InsertText("\n", false);
            companyDetails.InsertDocProperty(hired_company_details_line_two, light_formatting);
            companyDetails.Alignment = Alignment.center;        
            #endregion

            // Return the document now that it has been created.
            return document;
        }

        private static Table CreateAndInsertInvoiceTableAfter(Table t, ref DocX document)
        {
            // Grab data from somewhere (Most likely a database)
            DataTable data = GetDataFromDatabase();

            /* 
             * The trick to replacing one Table with another,
             * is to insert the new Table after the old one, 
             * and then remove the old one.
             */
            Table invoice_table = t.InsertTableAfterSelf(data.Rows.Count + 1, data.Columns.Count);
            invoice_table.Design = TableDesign.LightShadingAccent1;

            #region Table title
            Formatting table_title = new Formatting();
            table_title.Bold = true;

            invoice_table.Rows[0].Cells[0].Paragraph.InsertText("Description", false, table_title);
            invoice_table.Rows[0].Cells[0].Paragraph.Alignment = Alignment.center;
            invoice_table.Rows[0].Cells[1].Paragraph.InsertText("Hours", false, table_title);
            invoice_table.Rows[0].Cells[1].Paragraph.Alignment = Alignment.center;
            invoice_table.Rows[0].Cells[2].Paragraph.InsertText("Rate", false, table_title);
            invoice_table.Rows[0].Cells[2].Paragraph.Alignment = Alignment.center;
            invoice_table.Rows[0].Cells[3].Paragraph.InsertText("Amount", false, table_title);
            invoice_table.Rows[0].Cells[3].Paragraph.Alignment = Alignment.center;
            #endregion

            // Loop through the rows in the Table and insert data from the data source.
            for (int row = 1; row < invoice_table.RowCount; row++)
            {
                for (int cell = 0; cell < invoice_table.Rows[row].Cells.Count; cell++)
                {
                    Paragraph cell_paragraph = invoice_table.Rows[row].Cells[cell].Paragraph;
                    cell_paragraph.InsertText(data.Rows[row - 1].ItemArray[cell].ToString(), false);
                }
            }

            // We want to fill in the total by suming the values from the amount coloumn.
            Row total = invoice_table.InsertRow();
            total.Cells[0].Paragraph.InsertText("Total:", false);
            Paragraph total_paragraph = total.Cells[invoice_table.ColumnCount - 1].Paragraph;

            /* 
             * Lots of people are scared of LINQ,
             * so I will walk you through this line by line.
             * 
             * invoice_table.Rows is an IEnumerable<Row> (i.e a collection of rows), with LINQ you can query collections.
             * .Where(condition) is a filter that you want to apply to the items of this collection. 
             * My condition is that the index of the row must be greater than 0 and less than RowCount.
             * .Select(something) lets you select something from each item in the filtered collection.
             * I am selecting the Text value from each row, for example €100, then I am remove the €, 
             * and then I am parsing the remaining string as a double. This will return a collection of doubles,
             * the final thing I do is call .Sum() on this collection which return one double the sum of all the doubles,
             * this is the total.
             */
            double totalCost =
            (
                invoice_table.Rows
                .Where((row, index) => index > 0 && index < invoice_table.RowCount - 1)
                .Select(row => double.Parse(row.Cells[row.Cells.Count() - 1].Paragraph.Text.Remove(0, 1)))
            ).Sum();

            // Insert the total calculated above using LINQ into the total Paragraph.
            total_paragraph.InsertText(string.Format("€{0}", totalCost), false);

            // Let the tables coloumns expand to fit its contents.
            invoice_table.AutoFit = AutoFit.Contents;

            // Center the Table
            invoice_table.Alignment = Alignment.center;

            // Return the invloce table now that it has been created.
            return invoice_table;
        }

        // You need to rewrite this function to grab data from your data source.
        private static DataTable GetDataFromDatabase()
        {
            DataTable table = new DataTable();
            table.Columns.AddRange(new DataColumn[] { new DataColumn("Description"), new DataColumn("Hours"), new DataColumn("Rate"), new DataColumn("Amount") });

            table.Rows.Add
            (
                "Install wooden doors (Kitchen, Sitting room, Dining room & Bedrooms)",
                "5",
                "€25",
                string.Format("€{0}", 5 * 25)
            );

            table.Rows.Add
            (
                "Fit stairs",
                "20",
                "€30",
                string.Format("€{0}", 20 * 30)
            );

            table.Rows.Add
            (
                "Replace Sitting room window",
                "6",
                "€50",
                string.Format("€{0}", 6 * 50)
            );

            table.Rows.Add
            (
                "Build garden shed",
                "10",
                "€10",
                string.Format("€{0}", 10 * 10)
            );

            table.Rows.Add
             (
                 "Fit new lock on back door",
                 "0.5",
                 "€30",
                 string.Format("€{0}", 0.5 * 30)
             );

            table.Rows.Add
             (
                 "Tile Kitchen floor",
                 "24",
                 "€25",
                 string.Format("€{0}", 24 * 25)
             );

            return table;
        }
    }
}
