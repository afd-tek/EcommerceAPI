﻿using BiSanat.DAL.Repositories.Generic;
using System;
using System.Collections.Generic;
using System.Text;
using BiSanat.DAL.Entities;

namespace BiSanat.DAL.Repositories.Abstract
{
    public interface IOrderLineItemDAL : IRepository<OrderLineItem>
    {
        List<OrderLineItem> BulkInsert(List<OrderLineItem> items);
    }
}
