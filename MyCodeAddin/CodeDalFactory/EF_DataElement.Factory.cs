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
	public class EF_DataElementFactory:Common.Business.EF_DataElement
    {
        public static Common.Business.EF_DataElement Fetch(EF_DataElement data)
        {
            Common.Business.EF_DataElement item = (Common.Business.EF_DataElement)Activator.CreateInstance(typeof(Common.Business.EF_DataElement));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.DElement = data.DElement;
				                item.RowStatus = data.RowStatus;
				                item.DText = data.DText;
				                item.RefDomX = data.RefDomX;
				                item.Domain = data.Domain;
				                item.SHlpName = data.SHlpName;
				                item.SHlpField = data.SHlpField;
				                item.Text_S = data.Text_S;
				                item.Text_L = data.Text_L;
				                item.HeadText = data.HeadText;
				                item.DataType = data.DataType;
				                item.Leng = data.Leng;
				                item.Decimals = data.Decimals;
				                item.NegFlagX = data.NegFlagX;
				                item.UpperCaseX = data.UpperCaseX;
				                item.ValExiX = data.ValExiX;
				                item.CreatedUser = data.CreatedUser;
				                item.CreatedDate = data.CreatedDate;
				                item.ChangedUser = data.ChangedUser;
				                item.ChangedDate = data.ChangedDate;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<EF_DataElement>();
                var i = (from p in ctx.DataContext.EF_DataElement.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.DElement = i.DElement;
										this.RowStatus = i.RowStatus;
										this.DText = i.DText;
										this.RefDomX = i.RefDomX;
										this.Domain = i.Domain;
										this.SHlpName = i.SHlpName;
										this.SHlpField = i.SHlpField;
										this.Text_S = i.Text_S;
										this.Text_L = i.Text_L;
										this.HeadText = i.HeadText;
										this.DataType = i.DataType;
										this.Leng = i.Leng;
										this.Decimals = i.Decimals;
										this.NegFlagX = i.NegFlagX;
										this.UpperCaseX = i.UpperCaseX;
										this.ValExiX = i.ValExiX;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class EF_DataElementsFactory : Common.Business.EF_DataElements
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EF_DataElement
                        select EF_DataElementFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EF_DataElement
                        select EF_DataElementFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EF_DataElement>();
                var i = (from p in ctx.DataContext.EF_DataElement.Where(exp)
                         select EF_DataElementFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EF_DataElement>();
                var i = from p in ctx.DataContext.EF_DataElement.Where(exp)
                         select EF_DataElementFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
