using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_PBudExpEco))]
#if Dev
    [RunLocal]
#endif

	public class FI_PBudExpEco:ReadOnlyBase<FI_PBudExpEco>
    {
        #region Business Methods

		
        public string PBudExpEcoCode
        {
            get ;
            set ;
        }

		
        public string PBudExpEcoName
        {
            get ;
            set ;
        }

		
        public string PCode
        {
            get ;
            set ;
        }

		
        public bool IsGroup
        {
            get ;
            set ;
        }

		
        public bool Active
        {
            get ;
            set ;
        }

		
        public bool IsSys
        {
            get ;
            set ;
        }

		
        public bool IsPub
        {
            get ;
            set ;
        }

		
        public bool? IsRoot
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

		public static FI_PBudExpEco Create()
        {
            return EF.DataPortal.Create<FI_PBudExpEco>();
        }

		public static FI_PBudExpEco Fetch(System.Linq.Expressions.Expression<Func<FI_PBudExpEco, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_PBudExpEco>(exp,values);
            return EF.DataPortal.Fetch<FI_PBudExpEco>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_PBudExpEcos))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_PBudExpEcos:ReadOnlyListBase<FI_PBudExpEcos,FI_PBudExpEco>
    {
        #region Factory Methods

        public static FI_PBudExpEcos Fetch()
        {
            return EF.DataPortal.Fetch<FI_PBudExpEcos>();
        }

		public static FI_PBudExpEcos Fetch(System.Linq.Expressions.Expression<Func<FI_PBudExpEco, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_PBudExpEco>(exp,values);
            return EF.DataPortal.Fetch<FI_PBudExpEcos>(lambda);
		}

		public static FI_PBudExpEcos Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_PBudExpEcos>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_PBudExpEcos Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_PBudExpEco, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_PBudExpEcos>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_PBudExpEco>(exp,values)});
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
