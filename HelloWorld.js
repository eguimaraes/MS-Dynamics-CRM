function DisplayHelloWord(executionContext) {

    var formContext = executionContext.formContext;

    var firstname = formContext.getAttribute("firstname").getValue();

    alert("Hello World "+firstname)


}
