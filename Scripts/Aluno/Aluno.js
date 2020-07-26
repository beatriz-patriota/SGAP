function AlertaExcluir(alerta) {
    document.getElementById(alerta).style.display = 'block';
}
window.onload = function () {
    $.ajax({
        url: "/Aluno/GetAlunos",
        dataType: "JSON",
        type: "POST",
        success: function (response) {
            var append = "";
            response.forEach(function (item) {
                //CONVERSÃO DE DATA
                var dateString = `${item.Pessoas.DataNascimento}`.substr(6);
                var currentTime = new Date(parseInt(dateString));
                var month = currentTime.getMonth() + 1;
                var day = currentTime.getDate();
                var year = currentTime.getFullYear();
                var date = day + "/" + month + "/" + year;
                //DATA CONVERTIDA
                append += `<tr>
                                                <td>${item.Pessoas.Nome} </td>
                                                <td>${item.Pessoas.Telefone}</td>
                                                <td>${item.Pessoas.Email}</td>
                                                <td>${date}</td>
                                                <td>${item.Pessoas.Cpf}</td>
                                                <td>${item.Pessoas.Endereco}</td>
                                                <td><img onclick="Excluir(${item.Id},${item.Pessoas.Id})" src="../Imagens/Lixeira.svg"></td>
                                    </tr>`
            })
            if (response.length == 0) {
                append += `<tr style='text-align: center'> <td colspan='9'>Não há registros</td></tr>`
            }
            document.getElementById("corpoTabela").innerHTML = append;
        }
    })
}
function Excluir(Id, PessoaId) {
    $.ajax({
        url: "/Aluno/Excluir/",
        dataType: "JSON",
        type: "POST",
        data: {
            "Id": Id,
            "PessoaId": PessoaId
        },
        success: function (response) {
            AlertaExcluir("alertaVerde");
            document.getElementById("alertaVerde").innerHTML = response;
            setTimeout(function () {
                location.reload();
            }, 3000)
        }
    });
}