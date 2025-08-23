﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLTN.Shared.Messaging
{
    public interface IRabbitMQPublisher
    {
        void Publish<T>(string queueName, T message);
    }
}
