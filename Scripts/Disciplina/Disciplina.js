
function Alerta(nomeAlerta, mensagem) {
    $("#" + nomeAlerta).fadeIn("slow");
    document.getElementById(nomeAlerta).innerHTML = mensagem;
}

function Salvar() {
    var objDisciplina = {
        Nome: document.getElementById("txtNome").value,
        Periodo: document.getElementById("txtPeriodo").value
    }
    var valida = true;
    var mensagem = "";
    if (objDisciplina.Nome == "") {
        valida = false;
        mensagem += "O campo Nome é obrigatório! <br>";
    } if (objDisciplina.Periodo == "") {
        valida = false;
        mensagem += "O campo Período é obrigatório!<br>";
    } if (valida == true) {
        $.ajax({
            url: "/Disciplina/Salvar/",
            dataType: "JSON",
            type: "POST",
            data: {
                "disciplina": objDisciplina
            },
            success: function (response) {
                Alerta("alertaAzul", response);
            }
        });
    } else {
        Alerta("alertaVermelho", mensagem);
    }
}


