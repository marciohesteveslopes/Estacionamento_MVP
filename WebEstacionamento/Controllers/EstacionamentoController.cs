using Application.Interfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebEstacionamento.Controllers
{
    public class EstacionamentoController : Controller
    {
        private readonly IEstacionamentoApp _IEstacionamentoApp;

        public EstacionamentoController(IEstacionamentoApp IEstacionamentoApp)
        {
            _IEstacionamentoApp = IEstacionamentoApp;
        }

        // GET: Estacionamentos
        public async Task<IActionResult> Index()
        {
            return View(await _IEstacionamentoApp.List());
        }

        // GET: Estacionamentos/Details/5
        public async Task<IActionResult> Details(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estacionamento = await _IEstacionamentoApp.GetEntityById(id);
            if (estacionamento == null)
            {
                return NotFound();
            }

            return View(estacionamento);
        }

        // GET: Estacionamentos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Estacionamentos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DataHoraEntrada,Preco")] Estacionamento estacionamento)
        {
            //ModelState["mensagem"].Errors.Clear();
            //ModelState["NomePropriedade"].Errors.Clear();

            await _IEstacionamentoApp.Add(estacionamento);

            return RedirectToAction(nameof(Index));
        }

        // GET: Estacionamento/Edit/5
        public async Task<IActionResult> Edit(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estacionamento = await _IEstacionamentoApp.GetEntityById(id);
            if (estacionamento == null)
            {
                return NotFound();
            }
            return View(estacionamento);
        }

        // POST: Estacionamento/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,DataHoraEntrada,DataHoraSaida,DuracaoEstacionamento,HorasEfetivas,Preco,QuantiaAPagar")] Estacionamento estacionamento)
        {
            
            if (id != estacionamento.Id)
            {
                return NotFound();
            }

            try
            {
                await _IEstacionamentoApp.Update(estacionamento);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await EstacionamentoExists(estacionamento.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));

        }

        // GET: Estacionamento/Delete/5
        public async Task<IActionResult> Delete(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estacionamento = await _IEstacionamentoApp.GetEntityById(id);
            if (estacionamento == null)
            {
                return NotFound();
            }

            return View(estacionamento);
        }

        // POST: Estacionamento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var estacionamento = await _IEstacionamentoApp.GetEntityById(id);
            await _IEstacionamentoApp.Delete(estacionamento);

            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> EstacionamentoExists(string id)
        {

            var objeto = await _IEstacionamentoApp.GetEntityById(id);

            return objeto != null;
        }
    }
}
