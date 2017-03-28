using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_AllotType))]
#if Dev
    [RunLocal]
#endif

	public class PM_AllotType:ReadOnlyBase<PM_AllotType>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string AllotTypeCode
        {
            get ;
            set ;
        }

		
        public string AllotTypeName
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
        public decimal IncRate
        {
            get ;
            set ;
        }

		
        public bool IsFundIn
        {
            get ;
            set ;
        }

		
        public bool IsProjIn
        {
            get ;
            set ;
        }

		
        public bool Active
        {
            get ;
            set ;
        }

		
        public string SIncItemCode
        {
            get ;
            set ;
        }

		
        public string AllotModCode
        {
            get ;
            set ;
        }

		
        public string VendorCode
        {
            get ;
            set ;
        }

		
        public string AccCode
        {
            get ;
            set ;
        }

		
        public string GLMarkApp
        {
            get ;
            set ;
        }

		
        public string GLMarkInv
        {
            get ;
            set ;
        }

		
        public string GLMarkTax
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

		public static PM_AllotType Create()
        {
            return EF.DataPortal.Create<PM_AllotType>();
        }

		public static PM_AllotType Fetch(System.Linq.Expressions.Expression<Func<PM_AllotType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_AllotType>(exp,values);
            return EF.DataPortal.Fetch<PM_AllotType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_AllotTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_AllotTypes:ReadOnlyListBase<PM_AllotTypes,PM_AllotType>
    {
        #region Factory Methods

        public static PM_AllotTypes Fetch()
        {
            return EF.DataPortal.Fetch<PM_AllotTypes>();
        }

		public static PM_AllotTypes Fetch(System.Linq.Expressions.Expression<Func<PM_AllotType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_AllotType>(exp,values);
            return EF.DataPortal.Fetch<PM_AllotTypes>(lambda);
		}

		public static PM_AllotTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_AllotTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_AllotTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_AllotType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_AllotTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_AllotType>(exp,values)});
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
