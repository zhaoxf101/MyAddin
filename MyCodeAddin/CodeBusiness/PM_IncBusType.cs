using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_IncBusType))]
#if Dev
    [RunLocal]
#endif

	public class PM_IncBusType:ReadOnlyBase<PM_IncBusType>
    {
        #region Business Methods

		
        public string IncBusTypeCode
        {
            get ;
            set ;
        }

		
        public string IncBusTypeName
        {
            get ;
            set ;
        }

		
        public bool Active
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
        public string CreatedUser
        {
            get ;
            set ;
        }

		
        public DateTime? CreatedDate
        {
            get ;
            set ;
        }

		
        public string ChangedUser
        {
            get ;
            set ;
        }

		
        public DateTime? ChangedDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PM_IncBusType Create()
        {
            return EF.DataPortal.Create<PM_IncBusType>();
        }

		public static PM_IncBusType Fetch(System.Linq.Expressions.Expression<Func<PM_IncBusType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_IncBusType>(exp,values);
            return EF.DataPortal.Fetch<PM_IncBusType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_IncBusTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_IncBusTypes:ReadOnlyListBase<PM_IncBusTypes,PM_IncBusType>
    {
        #region Factory Methods

        public static PM_IncBusTypes Fetch()
        {
            return EF.DataPortal.Fetch<PM_IncBusTypes>();
        }

		public static PM_IncBusTypes Fetch(System.Linq.Expressions.Expression<Func<PM_IncBusType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_IncBusType>(exp,values);
            return EF.DataPortal.Fetch<PM_IncBusTypes>(lambda);
		}

		public static PM_IncBusTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_IncBusTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_IncBusTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_IncBusType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_IncBusTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_IncBusType>(exp,values)});
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
