function GetSet(executionContext) {

var formContext = executionContext.getFormContext();

// Get value
var website = formContext.getAttribute("websiteurl").getValue();
alert(website);

// Set value
formContext.getAttribute("websiteurl").setValue("http://newvalue.com");

// Alert new value
website = formContext.getAttribute("websiteurl").getValue();
alert(website);

}
