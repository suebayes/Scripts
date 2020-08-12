/* Creates a TOTAL FYTD measure for every selected measure.
*
* Author: Sue Bayes, twitter.com/sue_bayes
*
* This script, when excuted will loop through the currently selected measures
* creating a FYTD measure for each selected measure.
* The financial year end can be changed as per user need
* Note \ is used before the " sign, this allows " to be included in the code.



foreach (var m in Selected.Measures) {
m.Table.AddMeasure (
m.Name + " FYTD", // Name
"TOTALYTD (" + 
m.DaxObjectName + 
", 'Date' [Date]," + 
"\" 05/31 \")", // DAX expression 
m.DisplayFolder // Display Folder
);
}