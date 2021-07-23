function SomenteNumero() {
    if (event.keyCode < 48 || event.keyCode > 57) {
        return false;
    }
}
function abrirPopUp() {
    document.getElementById("PopUp").style.display = "block";
    document.getElementById("mask").style.display = "block";
}
function fecharPopUp() {
    document.getElementById("PopUp").style.display = "none";
    document.getElementById("mask").style.display = "none";
}
function KeyPress() {

    if (window.event.keyCode == '113') {
        var clickButton = document.getElementById("<%= ctl00$ContentPlaceHolder1$btnCancelar.ClienteID %>");
        clickButton.click();
    }
}
function mascara_data(campo) {
    if (campo.value.length == 2) {
        campo.value += '/';
    } if (campo.value.length == 5) {
        campo.value += '/';
    }
}


function mascara_hora(hora) {
    var myhora = '';
    myhora = myhora + hora.value;
    if (myhora.length == 2) {
        myhora = myhora + ':';
        hora.value += ':';
    }
    if (myhora.length == 5) {
        hrs = (hora.value.substring(0, 2));
        min = (hora.value.substring(3, 5));


        situacao = "";
        // verifica data e hora 
        if ((hrs < 00) || (hrs > 23) || (min < 00) || (min > 59)) {
            situacao = "falsa";
        }

        if (hora == "") {
            situacao = "falsa";
        }

        if (situacao == "falsa") {
            alert("Hora inválida!");
            hora.value.focus();
        }
    }
}

function SelectSingleRadiobutton(rdbtnid) {
    var rdBtn = document.getElementById(rdbtnid);
    var rdBtnList = document.getElementsByTagName("input");
    for (i = 0; i < rdBtnList.length; i++) {
        if (rdBtnList[i].type == "radio" && rdBtnList[i].id != rdBtn.id) {
            rdBtnList[i].checked = false;
        }
    }
}

function MarcarDesmarcar(rdbtnid) {
    var check = document.getElementById(rdbtnid);
    var bool = true;
    if (check.checked) {
        bool = false;
    } else {
        bool = true;
    }
    var rdBtnList = document.getElementsByTagName("input");
    for (i = 0; i < rdBtnList.length; i++) {
        if (rdBtnList[i].type == "CheckBox") {

            rdBtnList[i].checked = bool;

        }
    }
}

function Download(url) {
    window.location = url;
}

