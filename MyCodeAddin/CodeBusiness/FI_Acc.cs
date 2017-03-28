using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_Acc))]
#if Dev
    [RunLocal]
#endif

	public class FI_Acc:ReadOnlyBase<FI_Acc>
    {
        #region Business Methods

		
        public string AccChart
        {
            get ;
            set ;
        }

		
        public string AccCode
        {
            get ;
            set ;
        }

		
        public string AccCls
        {
            get ;
            set ;
        }

		
        public bool IsBalance
        {
            get ;
            set ;
        }

		
        public string GAccCode
        {
            get ;
            set ;
        }

		
        public string AccGrp
        {
            get ;
            set ;
        }

		
        public bool WDelX
        {
            get ;
            set ;
        }

		
        public string SText
        {
            get ;
            set ;
        }

		
        public string LText
        {
            get ;
            set ;
        }

		
        public string FuncArea
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

		public static FI_Acc Create()
        {
            return EF.DataPortal.Create<FI_Acc>();
        }

		public static FI_Acc Fetch(System.Linq.Expressions.Expression<Func<FI_Acc, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_Acc>(exp,values);
            return EF.DataPortal.Fetch<FI_Acc>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_Accs))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_Accs:ReadOnlyListBase<FI_Accs,FI_Acc>
    {
        #region Factory Methods

        public static FI_Accs Fetch()
        {
            return EF.DataPortal.Fetch<FI_Accs>();
        }

		public static FI_Accs Fetch(System.Linq.Expressions.Expression<Func<FI_Acc, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_Acc>(exp,values);
            return EF.DataPortal.Fetch<FI_Accs>(lambda);
		}

		public static FI_Accs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_Accs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_Accs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_Acc, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_Accs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_Acc>(exp,values)});
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
