using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(SM_AppStuDorm))]
#if Dev
    [RunLocal]
#endif

	public class SM_AppStuDorm:ReadOnlyBase<SM_AppStuDorm>
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

		
        public string StudentNo
        {
            get ;
            set ;
        }

		
        public string SDate
        {
            get ;
            set ;
        }

		
        public string EDate
        {
            get ;
            set ;
        }

		
        public string DormNo
        {
            get ;
            set ;
        }

		
        public string RoomNo
        {
            get ;
            set ;
        }

		
        public bool IsN
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

		public static SM_AppStuDorm Create()
        {
            return EF.DataPortal.Create<SM_AppStuDorm>();
        }

		public static SM_AppStuDorm Fetch(System.Linq.Expressions.Expression<Func<SM_AppStuDorm, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<SM_AppStuDorm>(exp,values);
            return EF.DataPortal.Fetch<SM_AppStuDorm>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(SM_AppStuDorms))]
#if Dev
    [RunLocal]
#endif
	
	public class SM_AppStuDorms:ReadOnlyListBase<SM_AppStuDorms,SM_AppStuDorm>
    {
        #region Factory Methods

        public static SM_AppStuDorms Fetch()
        {
            return EF.DataPortal.Fetch<SM_AppStuDorms>();
        }

		public static SM_AppStuDorms Fetch(System.Linq.Expressions.Expression<Func<SM_AppStuDorm, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<SM_AppStuDorm>(exp,values);
            return EF.DataPortal.Fetch<SM_AppStuDorms>(lambda);
		}

		public static SM_AppStuDorms Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<SM_AppStuDorms>(new Paging { Page=page,RowCount=rowCount});
        }

        public static SM_AppStuDorms Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<SM_AppStuDorm, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<SM_AppStuDorms>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<SM_AppStuDorm>(exp,values)});
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
