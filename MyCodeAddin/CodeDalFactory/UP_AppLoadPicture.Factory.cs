using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF;
using EF.Data;
using EF.Linq;
using EF.Server;
using EFramework.DalLinq;

namespace Common.DalFactory
{
	public class UP_AppLoadPictureFactory:Common.Business.UP_AppLoadPicture
    {
        public static Common.Business.UP_AppLoadPicture Fetch(UP_AppLoadPicture data)
        {
            Common.Business.UP_AppLoadPicture item = (Common.Business.UP_AppLoadPicture)Activator.CreateInstance(typeof(Common.Business.UP_AppLoadPicture));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Id = data.Id;
				                item.AppKey = data.AppKey;
				                item.ImageType = data.ImageType;
				                item.Version = data.Version;
				                item.PIndex = data.PIndex;
				                item.ImageUrl = data.ImageUrl;
				                item.Introduce = data.Introduce;
				                item.RowStatus = data.RowStatus;
				                item.CreateUser = data.CreateUser;
				                item.CreateDate = data.CreateDate;
				                item.ChangeUser = data.ChangeUser;
				                item.ChangeDate = data.ChangeDate;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<UP_AppLoadPicture>();
                var i = (from p in ctx.DataContext.UP_AppLoadPicture.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Id = i.Id;
										this.AppKey = i.AppKey;
										this.ImageType = i.ImageType;
										this.Version = i.Version;
										this.PIndex = i.PIndex;
										this.ImageUrl = i.ImageUrl;
										this.Introduce = i.Introduce;
										this.RowStatus = i.RowStatus;
										this.CreateUser = i.CreateUser;
										this.CreateDate = i.CreateDate;
										this.ChangeUser = i.ChangeUser;
										this.ChangeDate = i.ChangeDate;
					}
            }
        }
	}

	public class UP_AppLoadPicturesFactory : Common.Business.UP_AppLoadPictures
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.UP_AppLoadPicture
                        select UP_AppLoadPictureFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }

		private void DataPortal_Fetch(Paging page)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = (from p in ctx.DataContext.UP_AppLoadPicture
                        select UP_AppLoadPictureFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }

        private void DataPortal_Fetch(PagigExpress page)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var exp = page.Lambda.Resolve<UP_AppLoadPicture>();
                var i = (from p in ctx.DataContext.UP_AppLoadPicture.Where(exp)
                         select UP_AppLoadPictureFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var exp = lambda.Resolve<UP_AppLoadPicture>();
                var i = from p in ctx.DataContext.UP_AppLoadPicture.Where(exp)
                         select UP_AppLoadPictureFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
