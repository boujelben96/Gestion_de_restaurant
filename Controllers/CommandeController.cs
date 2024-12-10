using Gestion_de_restaurant.Models;
using Gestion_de_restaurant.Models.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gestion_de_restaurant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandesController : ControllerBase
    {
        private readonly ICommandeRepository commandeRepository;

        public CommandesController(ICommandeRepository commandeRepository)
        {
            this.commandeRepository = commandeRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            List<Commande> commandes = await commandeRepository.GetCommandes();
            return Ok(commandes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByID(int id)
        {
            Commande commande = await commandeRepository.GetCommandeById(id);
            if (commande == null)
                return NotFound();
            return Ok(commande);
        }

        // get commande by user name
        [HttpGet("user/{name}")]
        public async Task<IActionResult> GetByUserName(string name)
        {
            Commande commande = await commandeRepository.GetCommandeByName(name);
            if (commande == null)
                return NotFound();
            return Ok(commande);
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create(Commande commande)
        {
            Commande newCommande = await commandeRepository.AddCommande(commande);
            if (newCommande == null)
                return BadRequest("Problem creating commande");
            return CreatedAtAction(nameof(GetByID), new { id = newCommande.Id }, newCommande);
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(Commande commande)
        {
            await commandeRepository.UpdateCommande(commande);
            return NoContent();
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await commandeRepository.DeleteCommande(id);
            return NoContent();
        }
    }
}
