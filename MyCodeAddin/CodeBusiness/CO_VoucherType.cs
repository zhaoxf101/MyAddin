using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(CO_VoucherType))]
#if Dev
    [RunLocal]
#endif

	public class CO_VoucherType:ReadOnlyBase<CO_VoucherType>
    {
        #region Business Methods

		
        public string VouType
        {
            get ;
            set ;
        }

		
        public string PostRNR
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static CO_VoucherType Create()
        {
            return EF.DataPortal.Create<CO_VoucherType>();
        }

		public static CO_VoucherType Fetch(System.Linq.Expressions.Expression<Func<CO_VoucherType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<CO_VoucherType>(exp,values);
            return EF.DataPortal.Fetch<CO_VoucherType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(CO_VoucherTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class CO_VoucherTypes:ReadOnlyListBase<CO_VoucherTypes,CO_VoucherType>
    {
        #region Factory Methods

        public static CO_VoucherTypes Fetch()
        {
            return EF.DataPortal.Fetch<CO_VoucherTypes>();
        }

		public static CO_VoucherTypes Fetch(System.Linq.Expressions.Expression<Func<CO_VoucherType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<CO_VoucherType>(exp,values);
            return EF.DataPortal.Fetch<CO_VoucherTypes>(lambda);
		}

		public static CO_VoucherTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<CO_VoucherTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static CO_VoucherTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<CO_VoucherType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<CO_VoucherTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<CO_VoucherType>(exp,values)});
        }

        #endregion

		[Serializable]
        public class Paging
        {
            public int Page { get; set; }
            public int RowCount { get; set; }
            public int StartIndex
            {
                get 
                {
                    if (Page >= 0 && RowCount > 0)
                    {
                        return Page * RowCount;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        [Serializable]
        public class PagigExpress
        {
            public int Page { get; set; }
            public int RowCount { get; set; }
            public int StartIndex
            {
                get
                {
                    if (Page >= 0 && RowCount > 0)
                    {
                        return Page * RowCount;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            public LambdaExpression Lambda { get; set; }
        }

    }
}
