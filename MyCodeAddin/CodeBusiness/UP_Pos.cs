using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(UP_Pos))]
#if Dev
    [RunLocal]
#endif

	public class UP_Pos:ReadOnlyBase<UP_Pos>
    {
        #region Business Methods

		
        public Guid Id
        {
            get ;
            set ;
        }

		
        public string PosCode
        {
            get ;
            set ;
        }

		
        public string PosName
        {
            get ;
            set ;
        }

		
        public string PosType
        {
            get ;
            set ;
        }

		
        public string PosMac
        {
            get ;
            set ;
        }

		
        public string Supplier
        {
            get ;
            set ;
        }

		
        public DateTime? StorageTime
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
        public bool IsBind
        {
            get ;
            set ;
        }

		
        public string ShopOperator
        {
            get ;
            set ;
        }

		
        public string RowStatus
        {
            get ;
            set ;
        }

		
        public string CreateUser
        {
            get ;
            set ;
        }

		
        public DateTime? CreateDate
        {
            get ;
            set ;
        }

		
        public string ChangeUser
        {
            get ;
            set ;
        }

		
        public DateTime? ChangeDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static UP_Pos Create()
        {
            return EF.DataPortal.Create<UP_Pos>();
        }

		public static UP_Pos Fetch(System.Linq.Expressions.Expression<Func<UP_Pos, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<UP_Pos>(exp,values);
            return EF.DataPortal.Fetch<UP_Pos>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(UP_Poss))]
#if Dev
    [RunLocal]
#endif
	
	public class UP_Poss:ReadOnlyListBase<UP_Poss,UP_Pos>
    {
        #region Factory Methods

        public static UP_Poss Fetch()
        {
            return EF.DataPortal.Fetch<UP_Poss>();
        }

		public static UP_Poss Fetch(System.Linq.Expressions.Expression<Func<UP_Pos, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<UP_Pos>(exp,values);
            return EF.DataPortal.Fetch<UP_Poss>(lambda);
		}

		public static UP_Poss Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<UP_Poss>(new Paging { Page=page,RowCount=rowCount});
        }

        public static UP_Poss Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<UP_Pos, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<UP_Poss>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<UP_Pos>(exp,values)});
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
