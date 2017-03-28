using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_VoucherType))]
#if Dev
    [RunLocal]
#endif

	public class FI_VoucherType:ReadOnlyBase<FI_VoucherType>
    {
        #region Business Methods

		
        public string VouType
        {
            get ;
            set ;
        }

		
        public bool NegPostX
        {
            get ;
            set ;
        }

		
        public bool AssPostX
        {
            get ;
            set ;
        }

		
        public bool CustPostX
        {
            get ;
            set ;
        }

		
        public bool VendPostX
        {
            get ;
            set ;
        }

		
        public bool MMPostX
        {
            get ;
            set ;
        }

		
        public bool GLPostX
        {
            get ;
            set ;
        }

		
        public string ParkRNR
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

		
        public string CVType
        {
            get ;
            set ;
        }

		
        public string PVType
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_VoucherType Create()
        {
            return EF.DataPortal.Create<FI_VoucherType>();
        }

		public static FI_VoucherType Fetch(System.Linq.Expressions.Expression<Func<FI_VoucherType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_VoucherType>(exp,values);
            return EF.DataPortal.Fetch<FI_VoucherType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_VoucherTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_VoucherTypes:ReadOnlyListBase<FI_VoucherTypes,FI_VoucherType>
    {
        #region Factory Methods

        public static FI_VoucherTypes Fetch()
        {
            return EF.DataPortal.Fetch<FI_VoucherTypes>();
        }

		public static FI_VoucherTypes Fetch(System.Linq.Expressions.Expression<Func<FI_VoucherType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_VoucherType>(exp,values);
            return EF.DataPortal.Fetch<FI_VoucherTypes>(lambda);
		}

		public static FI_VoucherTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_VoucherTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_VoucherTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_VoucherType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_VoucherTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_VoucherType>(exp,values)});
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
