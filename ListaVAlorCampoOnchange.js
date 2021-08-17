// A namespace defined for the sample code
// As a best practice, you should always define 
// a unique namespace for your libraries
var Sdk = window.Sdk || {};
(function () {
    // Define some global variables
    var myUniqueId = "_myUniqueId"; // Define an ID for the notification
    var currentUserName = Xrm.Utility.getGlobalContext().userSettings.userName; // get current user name
    var message = currentUserName + ": Your JavaScript code in action!";
   

    // Code to run in the form OnLoad event
    this.formOnLoad = function (executionContext) {
        var formContext = executionContext.getFormContext();

        // display the form level notification as an INFO
        var assunto = formContext.getAttribute("nomecampo").getValue()[0].name;
       /*
        atos_reclamacaodocliente
        atos_frequenciafalha
        atos_possvelreproduzirinformeopassoapasso
        atos_procedimentosresultados

*/
formContext.ui.setFormNotification(assunto, "INFO", myUniqueId);

console.log(assunto)



        
    }

    // Code to run in the column OnChange event 
    this.attributeOnChange = function (executionContext) {
        var formContext = executionContext.getFormContext();
       

        // display the form level notification as an INFO
        var assunto = formContext.getAttribute("nomecampo").getValue()[0].name;
       formContext.ui.setFormNotification(assunto, "INFO", myUniqueId);

console.log(assunto)

       
    }

    // Code to run in the form OnSave event 
    this.formOnSave = function () {
        // Display an alert dialog
        Xrm.Navigation.openAlertDialog({ text: "Record saved." });
    }
}).call(Sdk);
