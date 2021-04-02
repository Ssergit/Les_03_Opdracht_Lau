using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Les_03_Opdracht_Lau.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class NumberController : ControllerBase
    {
        string filePath = "Number.txt";
        List<int> listNumber = new List<int>();

        // --------------------------------------------------

        // Lees een getal uit een tekstbestand

        [HttpGet]
        public ActionResult<List<int>> GetNumber()
        {
            if (System.IO.File.Exists(filePath) == false)
            {
                return NotFound();
            }

            string[] lines = System.IO.File.ReadAllLines(filePath);

            for( int i = 0; i < lines.Length; i++)
            {
                listNumber.Add(Convert.ToInt32(lines[i]));
            }

            return Ok(listNumber);
        }

        // Geef een getal mee en schrijf het weg naar het tekstbestand

        [HttpPost("one")]
        public ActionResult<List<int>> PostNumber()
        {
            string[] lines = {"63"};
                
            System.IO.File.WriteAllLines(filePath, lines);

            for (int i = 0; i < lines.Length; i++)
            {
                listNumber.Add(Convert.ToInt32(lines[i]));
            }

            return Ok(listNumber);
        }

        // Geef een random getal mee en schrijf het weg naar het tekstbestand

        [HttpPost("random")]
        public ActionResult<List<int>> PostRandomNumber()
        {
            Random generator = new Random();
            int randomNumber = generator.Next(1,11);

            string[] lines = { Convert.ToString(randomNumber) };

            System.IO.File.WriteAllLines(filePath, lines);

            for (int i = 0; i < lines.Length; i++)
            {
                listNumber.Add(Convert.ToInt32(lines[i]));
            }

            return Ok(listNumber);
        }
    }
}
