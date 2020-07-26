function Alerta(alerta) {
    document.getElementById(alerta).style.display = 'block';
}
window.onload = function () {
    $.ajax({
        url: "/Disciplina/GetDisciplinas/",
        dataType: "JSON",
        type: "POST",
        success: function (response) {
            let append = "";
            response.forEach(function (item) {
                append += `<tr>
                                            <td> ${item.Nome} </td>
                                            <td> ${item.Periodo}</td>
                                            <td><img src="../../Imagens/Lapis.svg"><img onclick="Excluir(${item.Id})" src="../../Imagens/Lixeira.svg"></td>
                                    </tr>`
            })
            if (response.length == 0) {
                append += `<tr style='text-align: center'><td colspan='3'>Não há registros</td></tr>`
            }
            document.getElementById("corpoTabela").innerHTML = append;
        }
    });
}
function Excluir(Id) {
    $.ajax({
        url: "/Disciplina/Excluir/",
        dataType: "JSON",
        type: "POST",
        data: {
            "Id": Id
        },
        success: function (response) {
            Alerta("alertaVerde");
            document.getElementById("alertaVerde").innerHTML = response;
            setTimeout(function () {
                location.reload();  
            }, 3000)
        }
    })
}