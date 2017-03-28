using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(SM_AppStu))]
#if Dev
    [RunLocal]
#endif

	public class SM_AppStu:ReadOnlyBase<SM_AppStu>
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

		
        public string AppBusCode
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
        public bool IsAppr
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

		public static SM_AppStu Create()
        {
            return EF.DataPortal.Create<SM_AppStu>();
        }

		public static SM_AppStu Fetch(System.Linq.Expressions.Expression<Func<SM_AppStu, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<SM_AppStu>(exp,values);
            return EF.DataPortal.Fetch<SM_AppStu>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(SM_AppStus))]
#if Dev
    [RunLocal]
#endif
	
	public class SM_AppStus:ReadOnlyListBase<SM_AppStus,SM_AppStu>
    {
        #region Factory Methods

        public static SM_AppStus Fetch()
        {
            return EF.DataPortal.Fetch<SM_AppStus>();
        }

		public static SM_AppStus Fetch(System.Linq.Expressions.Expression<Func<SM_AppStu, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<SM_AppStu>(exp,values);
            return EF.DataPortal.Fetch<SM_AppStus>(lambda);
		}

		public static SM_AppStus Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<SM_AppStus>(new Paging { Page=page,RowCount=rowCount});
        }

        public static SM_AppStus Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<SM_AppStu, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<SM_AppStus>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<SM_AppStu>(exp,values)});
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
