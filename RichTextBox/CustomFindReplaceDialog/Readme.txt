This example demonstrates how custom dialogs can be created and wired to work with the commands of the editor using MEF.

Note that all that is needed to have the commands of the editor use the custom dialog is to implement the respective interface and mark the class with the attribute [CustomFindReplaceDialog].