//-------------------------------------------------------------------------------------------
// getTextField
//-------------------------------------------------------------------------------------------

function getTextField(e){

    // Get the Form Context
    var formContext = e.getFormContext();

    // Get the value of a Contact's first name 
    var firstName = formContext.getAttribute("firstname").getValue();

}
