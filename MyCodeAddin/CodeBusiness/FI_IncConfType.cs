using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_IncConfType))]
#if Dev
    [RunLocal]
#endif

	public class FI_IncConfType:ReadOnlyBase<FI_IncConfType>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string IncConfTypeCode
        {
            get ;
            set ;
        }

		
        public string IncConfTypeName
        {
            get ;
            set ;
        }

		
        public string BusType
        {
            get ;
            set ;
        }

		
        public string VendorCode
        {
            get ;
            set ;
        }

		
        public string GLMark
        {
            get ;
            set ;
        }

		
        public bool VendorX
        {
            get ;
            set ;
        }

		
        public bool GovPayX
        {
            get ;
            set ;
        }

		
        public bool IsAdj
        {
            get ;
            set ;
        }

		
        public bool CollOpenX
        {
            get ;
            set ;
        }

		
        public string GovType
        {
            get ;
            set ;
        }

		
        public string IncTypeCode
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_IncConfType Create()
        {
            return EF.DataPortal.Create<FI_IncConfType>();
        }

		public static FI_IncConfType Fetch(System.Linq.Expressions.Expression<Func<FI_IncConfType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_IncConfType>(exp,values);
            return EF.DataPortal.Fetch<FI_IncConfType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_IncConfTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_IncConfTypes:ReadOnlyListBase<FI_IncConfTypes,FI_IncConfType>
    {
        #region Factory Methods

        public static FI_IncConfTypes Fetch()
        {
            return EF.DataPortal.Fetch<FI_IncConfTypes>();
        }

		public static FI_IncConfTypes Fetch(System.Linq.Expressions.Expression<Func<FI_IncConfType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_IncConfType>(exp,values);
            return EF.DataPortal.Fetch<FI_IncConfTypes>(lambda);
		}

		public static FI_IncConfTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_IncConfTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_IncConfTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_IncConfType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_IncConfTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_IncConfType>(exp,values)});
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
