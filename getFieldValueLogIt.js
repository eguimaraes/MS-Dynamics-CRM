function getAssunto(){

          var formContext = executionContext.getFormContext();

          
          var assunto = (formContext.getAttribute("nomeCampo").getValue()[0].name!=null)?formContext.getAttribute("nomecampo").getValue()[0].name:"";
          formContext.ui.setFormNotification(assunto, "INFO", myUniqueId);
  
  console.log(assunto)

}
