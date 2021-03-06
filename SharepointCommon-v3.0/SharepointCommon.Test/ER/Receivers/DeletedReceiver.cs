﻿using System;
using SharepointCommon.Attributes;
using SharepointCommon.Test.ER.Entities;

namespace SharepointCommon.Test.ER.Receivers
{
    public class DeletedReceiver : ListEventReceiver<DeletedItem>
    {
        [Async(false)]
        public override void ItemDeleted(int id)
        {
            try
            {
                DeletedItem.DeletedId = id;
                DeletedItem.IsDeleteCalled = true;
            }
            catch (Exception e)
            {
                DeletedItem.Exception = e;
            }
        }
    }   
    public class DeletedDocReceiver : ListEventReceiver<DeletedDoc>
    {
        [Async(false)]
        public override void ItemDeleted(int id)
        {
            try
            {
                DeletedDoc.DeletedId = id;
                DeletedDoc.IsDeleteCalled = true;
            }
            catch (Exception e)
            {
                DeletedDoc.Exception = e;
            }
        }
    }
}