var counter = 0;
function addService() {
    var table = document.getElementById("AddServiceTable");
    var row = table.insertRow(-1);
    var cell1 = row.insertCell(0);
    var cell2 = row.insertCell(1);
    var cell3 = row.insertCell(2);
    var cell4 = row.insertCell(3);
    cell1.innerHTML = '<input type="text" name="Services[' + counter + '].Description"/>';
    cell2.innerHTML = '<input type="text" name="Services[' + counter + '].Endpoint"/>';
    cell3.innerHTML = '<input type="text" name="Services[' + counter + '].Template"/>';
    cell4.innerHTML = '<input type="text" name="Services[' + counter + '].Time"/>';
    counter++;
}