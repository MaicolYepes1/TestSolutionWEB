let JSONFinal = [];

$(document).ready(function () {
    loadJSON();
});

function loadJSON() {
    $.ajax({
        async: true,
        url: 'https://raw.githubusercontent.com/marcovega/colombia-json/master/colombia.min.json',
        data: '',
        type: "GET",
        success: function (data) {
             JSONFinal = JSON.parse(data);
            if (JSONFinal.length > 0) {                
                a = document.querySelector("#deparment");
                for (var i = 0; i < JSONFinal.length; i++) {
                    op = document.createElement("option");
                    op.value = JSONFinal[i].departamento;
                    op.text = JSONFinal[i].departamento;
                    a.add(op);
                }
            } else {
            }
        },
        error: function (data) {

        }
    });
}

function changeFunc() {
    var selectBox = document.getElementById("deparment");
    var selectedValue = selectBox.options[selectBox.selectedIndex].value;    
    a = document.querySelector("#city");
    a.innerHTML = "";
    for (var i = 0; i < JSONFinal[selectBox.selectedIndex - 1].ciudades.length; i++) {
        op = document.createElement("option");
        op.value = JSONFinal[selectBox.selectedIndex - 1].ciudades[i];
        op.text = JSONFinal[selectBox.selectedIndex - 1].ciudades[i];
        a.add(op);
    }
}