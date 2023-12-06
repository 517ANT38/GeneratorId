using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GeneratorId.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdGeneratorController : ControllerBase
    {
        Random random = new Random();
        [HttpGet("guid")]
        public string Get()
        {
            return Guid.NewGuid().ToString();
        }

        // GET api/<IdGeneratorController>/5
        [HttpGet("numSet/{cod}/{idCom}")]
        public long Get(int cod,int idCom)
        {
            long resId=random.NextInt64(12,long.MaxValue);
            
            string res="0"+ ((int)long.Parse(DateTime.Now.ToString("yyMMddHHmmssffff")));
            //Console.WriteLine(res); 
            res += cod;
            res += idCom;
            res += random.Next(0, 100);

            long.TryParse(res,out  resId);
            return resId ;
        }

        [HttpGet("numSet2/{cod}/{idCom}")]
        public long Get1(int cod, int idCom)
        {


            long resId = (long)(DateTime.Now.Subtract(DateTime.MinValue).TotalMilliseconds);
           
            resId |= cod<<41;
           
            resId = resId << 5;
          
            resId |= idCom ;
           
            resId = resId << 5;
           
            resId |= random.Next(345, int.MaxValue) << 20;
           
            resId = resId << 12;
           
            return resId;
        }
        [HttpGet("numSet3/{cod}/{idCom}")]
        public ulong Get2(uint cod, uint idCom)
        {

           
            ulong resId =(ulong)DateTime.Now.Subtract(DateTime.MinValue).TotalMilliseconds;

            resId<<=41;
            
            resId |= cod ;
            
            resId = resId << 5;
            
            resId |= idCom ;
            
            resId <<=  5;
            resId <<= 12;
            Random rnd = new Random();
            uint g =(uint) rnd.Next(0, 100);
            resId |= g;
            
            return resId;
        }

    }
}
