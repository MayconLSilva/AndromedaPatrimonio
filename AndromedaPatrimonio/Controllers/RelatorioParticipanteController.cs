using AndromedaPatrimonio.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace AndromedaPatrimonio.Controllers
{
    public class RelatorioParticipanteController : Controller
    {
        public IActionResult Index()
        {
            //List<Participante> dsParticipante = new List<Participante>();
            //var part1 = new Participante()
            //{
            //    id = 1,
            //    nome ="maycon"
            //};
            //var part2 = new Participante()
            //{
            //    id = 2,
            //    nome = "maycon 2"
            //};
            //dsParticipante.Add(part1);
            //dsParticipante.Add(part2);
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("id",typeof(int));
            dataTable.Columns.Add("nome", typeof(string));
            dataTable.Rows.Add(1, "maycon");
            dataTable.Rows.Add(2, "maycon2");

            //var viewer = new Microsoft.Reporting.WebForms.ReportViewer();
            //viewer.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Local;
            //viewer.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"CaminhoDoSeuRelatorio.rdlc";
            //viewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("DataSetParticipante", (System.Data.DataTable)dataTable));

            //ViewBag.ReportViewer = viewer;
            return View();
        }
    }
}
