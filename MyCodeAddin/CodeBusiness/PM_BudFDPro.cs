using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_BudFDPro))]
#if Dev
    [RunLocal]
#endif

	public class PM_BudFDPro:ReadOnlyBase<PM_BudFDPro>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string AppNo
        {
            get ;
            set ;
        }

		
        public string BudBusCode
        {
            get ;
            set ;
        }

		
        public string Year
        {
            get ;
            set ;
        }

		
        public string ProjCode
        {
            get ;
            set ;
        }

		
        public bool IsProjBud
        {
            get ;
            set ;
        }

		
        public decimal FDAmt
        {
            get ;
            set ;
        }

		
        public decimal BudAmt
        {
            get ;
            set ;
        }

		
        public bool IsCheck
        {
            get ;
            set ;
        }

		
        public bool IsAdd
        {
            get ;
            set ;
        }

		
        public bool IsAppr
        {
            get ;
            set ;
        }

		
        public bool CanEdit
        {
            get ;
            set ;
        }

		
        public bool IsVBudProj
        {
            get ;
            set ;
        }

		
        public string BudProjCode
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
        public string YSWF
        {
            get ;
            set ;
        }

		
        public bool Cancelled
        {
            get ;
            set ;
        }

		
        public bool Approved
        {
            get ;
            set ;
        }

		
        public string ObjectId
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

		public static PM_BudFDPro Create()
        {
            return EF.DataPortal.Create<PM_BudFDPro>();
        }

		public static PM_BudFDPro Fetch(System.Linq.Expressions.Expression<Func<PM_BudFDPro, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_BudFDPro>(exp,values);
            return EF.DataPortal.Fetch<PM_BudFDPro>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_BudFDPros))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_BudFDPros:ReadOnlyListBase<PM_BudFDPros,PM_BudFDPro>
    {
        #region Factory Methods

        public static PM_BudFDPros Fetch()
        {
            return EF.DataPortal.Fetch<PM_BudFDPros>();
        }

		public static PM_BudFDPros Fetch(System.Linq.Expressions.Expression<Func<PM_BudFDPro, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_BudFDPro>(exp,values);
            return EF.DataPortal.Fetch<PM_BudFDPros>(lambda);
		}

		public static PM_BudFDPros Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_BudFDPros>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_BudFDPros Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_BudFDPro, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_BudFDPros>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_BudFDPro>(exp,values)});
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
