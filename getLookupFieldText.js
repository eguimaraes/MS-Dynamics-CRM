//-------------------------------------------------------------------------------------------
// getLookupFieldText
//-------------------------------------------------------------------------------------------

function getLookupFieldText(e){

    // Get the Form Context
    var formContext = e.getFormContext();

    // Get the Parent Company name of a Contact
    var companyName = formContext.getAttribute("parentcustomerid").getValue()[0].name;

}
