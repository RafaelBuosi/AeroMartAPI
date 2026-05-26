using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AeroMartApi.Data;
using AeroMartApi.Models;

[Route("api/[controller]")]
[ApiController]
public class ProdutosController : ControllerBase
{
    private readonly AppDbContext _context;
    public ProdutosController(AppDbContext context) => _context = context;

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Produto>>> Get() => await _context.Produtos.ToListAsync();

    [HttpPost]
    public async Task<ActionResult<Produto>> Post(Produto p) {
        _context.Produtos.Add(p);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(Get), new { id = p.Id }, p);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Produto p) {
        if (id != p.Id) return BadRequest();
        _context.Entry(p).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id) {
        var p = await _context.Produtos.FindAsync(id);
        if (p == null) return NotFound();
        _context.Produtos.Remove(p);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}