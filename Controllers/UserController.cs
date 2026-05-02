using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mts_Api.Data;
using Mts_Api.Models;

namespace Mts_Api.Controllers
{
    
        [Route("api/[controller]")] // Определяет маршрут для этого контроллера: /api/users
        [ApiController] // Указывает, что это API-контроллер

        public class UsersController : ControllerBase
        {

            private readonly MtsDbContext _context;

            // Конструктор: DbContext будет внедрен через Dependency Injection
            public UsersController(MtsDbContext context)
            {
                _context = context;
            }

            // GET: api/Users
            // Получить список всех пользователей
            [HttpGet]
            public async Task<ActionResult<IEnumerable<User>>> GetUsers()
            {
                if (_context.Users == null)
                {
                    return NotFound(); // Если DbSet<User> не существует
                }
                return await _context.Users.ToListAsync();
            }

            // GET: api/Users/5
            // Получить пользователя по ID
            [HttpGet("{id}")]
            public async Task<ActionResult<User>> GetUser(int id)
            {
                if (_context.Users == null)
                {
                    return NotFound();
                }
                var user = await _context.Users.FindAsync(id);

                if (user == null)
                {
                    return NotFound(); // Пользователь с таким ID не найден
                }

                return user;
            }

            // PUT: api/Users/5
            // Обновить существующего пользователя
            // Для простоты пока не будем реализовывать все проверки.
            [HttpPut("{id}")]
            public async Task<IActionResult> PutUser(int id, User user)
            {
                if (id != user.IdUser) // Проверка, что ID в URL соответствует ID объекта
                {
                    return BadRequest();
                }

                _context.Entry(user).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return NoContent(); // 204 No Content - успешное обновление без возврата данных
            }

            // POST: api/Users
            // Добавить нового пользователя
            [HttpPost]
            public async Task<ActionResult<User>> PostUser(User user)
            {
                if (_context.Users == null)
                {
                    return Problem("Entity set 'MtsDbContext.Users' is null.");
                }
                _context.Users.Add(user);
                await _context.SaveChangesAsync();

                // Возвращаем 201 Created и URL нового ресурса
                return CreatedAtAction("GetUser", new { id = user.IdUser }, user);
            }

            // DELETE: api/Users/5
            // Удалить пользователя
            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteUser(int id)
            {
                if (_context.Users == null)
                {
                    return NotFound();
                }
                var user = await _context.Users.FindAsync(id);
                if (user == null)
                {
                    return NotFound();
                }

                _context.Users.Remove(user);
                await _context.SaveChangesAsync();

                return NoContent(); // 204 No Content - успешное удаление без возврата данных
            }

            private bool UserExists(int id)
            {
                return (_context.Users?.Any(e => e.IdUser == id)).GetValueOrDefault();
            }
        }
}


