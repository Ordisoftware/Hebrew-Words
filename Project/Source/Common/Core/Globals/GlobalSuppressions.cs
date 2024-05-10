﻿// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.

[assembly: SuppressMessage("Style", "IDE0290:Utiliser le constructeur principal", Justification = "<En attente>", Scope = "module")]

[assembly: SuppressMessage("Critical Code Smell", "S1699:Constructors should only call non-overridable methods", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Critical Code Smell", "S2365:Properties should not make collection or array copies", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Critical Code Smell", "S2696:Instance members should not write to \"static\" fields", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Critical Code Smell", "S3973:A conditionally executed single line should be denoted by indentation", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Info Code Smell", "S1135:Track uses of \"TODO\" tags", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Major Code Smell", "S1066:Collapsible \"if\" statements should be merged", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Major Code Smell", "S108:Nested blocks of code should not be left empty", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Major Code Smell", "S112:General exceptions should never be thrown", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Major Code Smell", "S1121:Assignments should not be made from within sub-expressions", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Major Code Smell", "S1144:Unused private types or members should be removed", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Major Code Smell", "S125:Sections of code should not be commented out", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Major Code Smell", "S1854:Unused assignments should be removed", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Major Code Smell", "S3358:Ternary operators should not be nested", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Major Code Smell", "S3928:Parameter names used into ArgumentException constructors should match an existing one ", Justification = "Irrelevant?", Scope = "module")]
[assembly: SuppressMessage("Major Code Smell", "S4220:Events should have proper arguments", Justification = "Irrelevant?", Scope = "module")]
[assembly: SuppressMessage("Major Code Smell", "S907:\"goto\" statement should not be used", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Minor Code Smell", "S101:Types should be named in PascalCase", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Minor Code Smell", "S2486:Generic exceptions should not be ignored", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Minor Code Smell", "S3963:\"static\" fields should be initialized inline", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Minor Code Smell", "S2386:Mutable fields should not be \"public static\"", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Minor Code Smell", "S4663:Comments should not be empty", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Minor Bug", "S3887:Mutable, non-private fields should not be \"readonly\"", Justification = "Opinion", Scope = "module")]

[assembly: SuppressMessage("Style", "IDE0008:Utiliser un type explicite", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Style", "IDE0011:Ajouter des accolades", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Style", "IDE0062:Rendre la fonction locale 'static'", Justification = "Less optimized proc call", Scope = "module")]

[assembly: SuppressMessage("Maintainability", "RCS1139:Add summary element to documentation comment.", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Maintainability", "RCS1141:Add 'param' element to documentation comment.", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Performance", "RCS1096:Convert 'HasFlag' call to bitwise operation (or vice versa).", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Readability", "RCS1018:Add accessibility modifiers (or vice versa).", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Readability", "RCS1123:Add parentheses when necessary.", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Redundancy", "RCS1036:Remove redundant empty line.", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Simplification", "RCS1061:Merge 'if' with nested 'if'.", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Style", "RCS1001:Add braces (when expression spans over multiple lines).", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Style", "RCS1003:Add braces to if-else (when expression spans over multiple lines).", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Style", "RCS1217:Convert interpolated string to concatenation.", Justification = "Opinion", Scope = "module")]

[assembly: SuppressMessage("Security", "SCS0001:Potential Command Injection vulnerability was found where '{0}' in '{1}' may be tainted by user-controlled data from '{2}' in method '{3}'.", Justification = "N/A for MeteoBlue.com URL as used", Scope = "module")]

[assembly: SuppressMessage("Performance", "U2U1002:Method can be declared static", Justification = "Can be opinion or anti-pattern (analyzer may be improved)", Scope = "module")]
[assembly: SuppressMessage("Performance", "U2U1010:Internal leaf classes can be sealed", Justification = "Can be opinion", Scope = "module")]
[assembly: SuppressMessage("Performance", "U2U1201:Local collections should be initialized with capacity", Justification = "Can be opinion", Scope = "module")]

[assembly: SuppressMessage("Performance", "CA1822:Marquer les membres comme étant static", Justification = "Opinion", Scope = "module")]

[assembly: SuppressMessage("Design", "MA0012:Do not raise reserved exception type", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Design", "MA0016:Prefer returning collection abstraction instead of implementation", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Design", "MA0026:Fix TODO comment", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Design", "MA0038:Make method static", Justification = "Opinion based and can reduce performances", Scope = "module")]
[assembly: SuppressMessage("Design", "MA0041:Make property static", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Design", "MA0046:Use EventHandler<T> to declare events", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Design", "MA0048:File name must match type name", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Design", "MA0053:Make class sealed", Justification = "Can be opinion", Scope = "module")]
[assembly: SuppressMessage("Design", "MA0056:Do not call overridable members in constructor", Justification = "N/A", Scope = "module")]
[assembly: SuppressMessage("Design", "MA0076:Do not use implicit culture-sensitive ToString in interpolated strings", Justification = "Analysis error or TODO", Scope = "module")]
[assembly: SuppressMessage("Usage", "MA0011:IFormatProvider is missing", Justification = "TODO", Scope = "module")]
[assembly: SuppressMessage("Usage", "MA0002:IEqualityComparer<string> or IComparer<string> is missing", Justification = "TODO", Scope = "module")]
[assembly: SuppressMessage("Usage", "MA0006:Use String.Equals instead of equality operator", Justification = "Opinion or TODO", Scope = "module")]
[assembly: SuppressMessage("Usage", "MA0091:Sender should be 'this' for instance events", Justification = "Opinion or N/A", Scope = "module")]
[assembly: SuppressMessage("Style", "MA0003:Add parameter name to improve readability", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Style", "MA0007:Add a comma after the last value", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Style", "MA0071:Avoid using redundant else", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Performance", "MA0028:Optimize StringBuilder usage", Justification = "Incorrect for .NET Framework (two calls instead on one)", Scope = "module")]

[assembly: SuppressMessage("CodeSmell", "EPC12:Suspicious exception handling: only Message property is observed in exception block.", Justification = "Opinion based or N/A", Scope = "module")]
[assembly: SuppressMessage("CodeSmell", "ERP022:Unobserved exception in generic exception handler", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("PropertyChangedAnalyzers.PropertyChanged", "INPC001:The class has mutable properties and should implement INotifyPropertyChanged.", Justification = "Opinion", Scope = "module")]

[assembly: SuppressMessage("Design", "GCop101:Too many parameters as argument. Define a container and encapsulate them", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Design", "GCop112:This class is too large. Break its responsibilities down into more classes.", Justification = "N/A or Opinion", Scope = "module")]
[assembly: SuppressMessage("Design", "GCop116:Break this down into smaller methods. If such methods would become meaningless as standalone methods in the context of the class, you can refactor this method into a Stateful Service class", Justification = "N/A (using Meziantou.Analyzer)", Scope = "module")]
[assembly: SuppressMessage("Design", "GCop117:The meaning of \"{0}\" is not obvious. Specify the parameter's name explicitly.", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Design", "GCop119:Don’t use {0} parameters in method definition. To return several objects, define a class or struct for your method return type.", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Design", "GCop136:All constants and class fields should be defined at the top of the class, before all methods.", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Design", "GCop138:When you catch an exception you should throw exception or at least log error", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Design", "GCop148:All constructors should be before all methods in a class.", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Design", "GCop160:This is not readable. Either refactor into a method, or use If / else statement.", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Performance", "GCop302:Since '{0}' implements IDisposable, wrap it in a using() statement", Justification = "N/A (checked by another analyzer)", Scope = "module")]
[assembly: SuppressMessage("Refactoring", "GCop627:{0}", Justification = "Opinion or doubtful", Scope = "module")]
[assembly: SuppressMessage("Refactoring", "GCop656:Join string expressions", Justification = "Opinion", Scope = "module")]
[assembly: SuppressMessage("Refactoring", "GCop658:Use compound assignment.", Justification = "Sometimes doubtful and checked by other alalyser", Scope = "module")]
[assembly: SuppressMessage("Refactoring", "GCop659:Use 'var' instead of explicit type.", Justification = "Opinion or can cause problems with non-generic and simple collections", Scope = "module")]
[assembly: SuppressMessage("Style", "GCop406:Mark {0} field as read-only.", Justification = "Bugged and checked by other alalyser", Scope = "module")]
[assembly: SuppressMessage("Style", "GCop436:As the implementation is relatively long, change this into a standard method implementation.", Justification = "Opinion or N/A (need a parameter for the analyzer)", Scope = "module")]
[assembly: SuppressMessage("Style", "GCop437:Complete the task associated to this \"TODO\" comment.", Justification = "N/A", Scope = "module")]
[assembly: SuppressMessage("Usage", "GCop511:Either remove the parameter documentation node, or describe it properly.", Justification = "Opinion", Scope = "module")]

[assembly: SuppressMessage("CodeQuality", "IDE0079:Retirer la suppression inutile", Justification = "For GCop when no nuget added", Scope = "module")]

[assembly: SuppressMessage("Major Code Smell", "S6561:Avoid using \"DateTime.Now\" for benchmarking or timing operations", Justification = "N/A", Scope = "module")]
[assembly: SuppressMessage("Major Code Smell", "S6562:Always set the \"DateTimeKind\" when creating new \"DateTime\" instances", Justification = "Opinion", Scope = "module")]

[assembly: SuppressMessage("Naming", "VSSpell001:Spell Check", Justification = "N/A or opinion", Scope = "module")]

[assembly: SuppressMessage("Correctness", "SS045:A static field relies on the value of another static field which is defined in the same type. Static fields are initialized in order of appearance.", Justification = "N/A or opinion or analysis error on properties", Scope = "module")]
[assembly: SuppressMessage("Correctness", "SS002:DateTime.Now was referenced", Justification = "N/A", Scope = "module")]

[assembly: SuppressMessage("Correctness", "SS003:The operands of a divisive expression are both integers and result in an implicit rounding.", Justification = "N/A", Scope = "module")]
[assembly: SuppressMessage("ApiDesign", "SS039:An enum should specify a default value", Justification = "N/A or opinion", Scope = "module")]
[assembly: SuppressMessage("ApiDesign", "SS036:An enum should explicitly specify its values", Justification = "N/A or opinion", Scope = "module")]

// TODO remove if not using .NET Framework
[assembly: SuppressMessage("Minor Code Smell", "S6603:The collection-specific \"TrueForAll\" method should be used instead of the \"All\" extension", Justification = "N/A for .NET Framework", Scope = "module")]
[assembly: SuppressMessage("Minor Code Smell", "S6605:Collection-specific \"Exists\" method should be used instead of the \"Any\" extension", Justification = "N/A for .NET Framework", Scope = "module")]
