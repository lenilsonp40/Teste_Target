using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StringAnalysisApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Questao02MaisculaOuMinusculaController : ControllerBase
    {
        
        [HttpPost]
        public IActionResult Post([FromBody] string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
            {
                return BadRequest(new { Message = "A string fornecida está vazia ou nula." });
            }

            int count = CountLetterA(inputString);

            if (count > 0)
            {
                return Ok(new { Message = $"A letra 'a' ocorre {count} vezes na string." });
            }
            else
            {
                return Ok(new { Message = "A letra 'a' não está presente na string." });
            }
        }

        private int CountLetterA(string input)
        {
            int count = 0;
            foreach (char c in input)
            {
                if (char.ToLower(c) == 'a')
                {
                    count++;
                }
            }
            return count;
        }
    }
}