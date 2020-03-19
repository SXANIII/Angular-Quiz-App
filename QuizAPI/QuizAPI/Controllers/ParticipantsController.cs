using QuizAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;

namespace QuizAPI.Controllers
{
    public class ParticipantsController : ApiController
    {
        [HttpPost]
        [Route("api/InsertParticipant")]
        public Participant Insert(Participant model) 
        {
            using (DBModels db = new DBModels())
                {
                    db.Participants.Add(model);
                    db.SaveChanges();
                    return model;
                }
            
        }

        [HttpPost]
        [Route("api/UpdateOutput")]
        public void UpdateOutput(Participant model){ 
            using (DBModels db = new DBModels())
                {
                    db.Entry(model).State = EntityState.Modified;
                    db.SaveChanges();
                }    
            
        
        }
    }
}
