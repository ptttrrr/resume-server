using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.Server.Data;
using Resume.Server.Data.UnitOfWork;
using Resume.Server.Mappers;
using Resume.Server.Contracts;
using Resume.Server.Business.Handlers;

namespace Resume.Server.Business
{
    public class MessageService
    {

        public bool PostMessage(MessageDTO messageDTO, string conn)
        {
            var request = Handlers.MessageHandler.SendMessageToQueue(messageDTO.TextMessage, conn);
            return request;    
        }

    }
}
