/-------------------------------------------------------------------------------------------
// setTextField
//-------------------------------------------------------------------------------------------

function setTextField(e){

    // Get the Form Context
    var formContext = e.getFormContext();

    // Set the Contact's first name to Joe
    formContext.getAttribute("firstname").setValue("Joe");

    // Set the Contact's first name to a variable
    var firstName = "Joe";
    formContext.getAttribute("firstname").setValue(firstName);

}
