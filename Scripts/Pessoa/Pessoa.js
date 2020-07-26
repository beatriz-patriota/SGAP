function AlternarAlunoProfessor() {
    var tipo = document.getElementById('ddlTipo').value;
    var professor = document.getElementById('Professor');
    if (tipo == "Aluno") {
        professor.style.display = 'none';
    } else if (tipo == "Professor") {
        professor.style.display = 'block';
    }
}
function MudarEstado(Alerta) {
    document.getElementById(Alerta).style.display = 'block';
}
function Salvar() {
    var opcao = document.getElementById('ddlTipo').value;

    var objPessoa = {
        Nome: document.getElementById("txtNome").value,
        Telefone: document.getElementById("txtTelefone").value,
        Email: document.getElementById("txtEmail").value,
        DataNascimento: document.getElementById("txtDataNascimento").value,
        Cpf: document.getElementById("txtCpf").value,
        Endereco: "Rua: " + document.getElementById("txtRua").value + " Nº: " + document.getElementById("txtNumero").value + " Estado: " + document.getElementById("txtEstado").value + " Cidade: " + document.getElementById("txtCidade").value
    }
    var objEndereco = {
        Rua: document.getElementById("txtRua").value,
        Numero: document.getElementById("txtNumero").value,
        Estado: document.getElementById("txtEstado").value,
        Cidade: document.getElementById("txtCidade").value
    }
    var objProfessor = {
        NumeroDocumento: document.getElementById("txtNumDoc").value,
        TipoDocumento: document.getElementById("txtTipoDoc").value,
    }
    var valida = true;
    var mensagem = "";
    if (objPessoa.Nome == "") {
        valida = false;
        mensagem += "O campo Nome é obrigatório! <br>"
    } if (objPessoa.Telefone == "") {
        valida = false;
        mensagem += "O campo Telefone é obrigatório!<br>"
    } if (objPessoa.DataNascimento == "") {
        valida = false;
        mensagem += "O campo Data de Nascimento é obrigatório! <br>"
    } if (objPessoa.Email == "") {
        valida = false;
        mensagem += "O campo E-mail é obrigatório! <br>"
    } if (objPessoa.Cpf == "") {
        valida = false;
        mensagem += "O campo CPF é obrigatório! <br>"
    } if (objEndereco.Rua == "") {
        valida = false;
        mensagem += "O campo Rua é obrigatório! <br>"
    } if (objEndereco.Numero == "") {
        valida = false;
        mensagem += "O campo Número é obrigatório! <br>"
    } if (objEndereco.Cidade == "") {
        valida = false;
        mensagem += "O campo Cidade é obrigatório! <br>"
    } if (objEndereco.Estado == "") {
        valida = false;
        mensagem += "O campo Estado é obrigatório! <br>"  
    
    } if (objProfessor.NumeroDocumento == "" && opcao == "Professor") {
        valida = false;
        mensagem += "O campo Número do Documento é obrigatório! <br>"
    } if (objProfessor.TipoDocumento == "" && opcao == "Professor") {
        valida = false;
        mensagem += "O campo Tipo do Documento é obrigatório! <br>"
    } if (valida == true) {
        $.ajax({
            url: "/Pessoa/Salvar/",
            dataType: "JSON",
            type: "POST",
            data: {
                "pessoa": objPessoa,
                "tipo": opcao,
                "professor": objProfessor
            },
            success: function (response) {
                MudarEstado("alertaVerde");
                document.getElementById("alertaVerde").innerHTML = response;
                setTimeout(function () {
                    $("#alertaVerde").hide("slow")
                }, 3000)
            }
        });
    } else {
        MudarEstado("alertaVermelho");
        document.getElementById("alertaVermelho").innerHTML = mensagem;
    }
    window.scrollTo(0, 0);
}

