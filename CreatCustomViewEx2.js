function casePriorityIcons(rowData, userLCID) {  
  var data = JSON.parse(rowData);  
  var priority = data.prioritycode;  
  var imgWebResource = "";  
  var imgTooltip = "";  
  switch (priority) {  
    case "High":  
      imgWebResource = "ashv_high";  
      imgTooltip = "High Priority Case";  
      break;  
    case "Low":  
      imgWebResource = "ashv_low";  
      imgTooltip = "Low Priority Case";  
      break;  
    default:  
      imgWebResource = "ashv_normal";  
      imgTooltip = "Normal Priority Case";  
      break;  
  }  
  return [imgWebResource, imgTooltip];  
}  
