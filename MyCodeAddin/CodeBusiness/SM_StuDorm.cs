using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(SM_StuDorm))]
#if Dev
    [RunLocal]
#endif

	public class SM_StuDorm:ReadOnlyBase<SM_StuDorm>
    {
        #region Business Methods

		
        public string Client
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

		public static SM_StuDorm Create()
        {
            return EF.DataPortal.Create<SM_StuDorm>();
        }

		public static SM_StuDorm Fetch(System.Linq.Expressions.Expression<Func<SM_StuDorm, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<SM_StuDorm>(exp,values);
            return EF.DataPortal.Fetch<SM_StuDorm>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(SM_StuDorms))]
#if Dev
    [RunLocal]
#endif
	
	public class SM_StuDorms:ReadOnlyListBase<SM_StuDorms,SM_StuDorm>
    {
        #region Factory Methods

        public static SM_StuDorms Fetch()
        {
            return EF.DataPortal.Fetch<SM_StuDorms>();
        }

		public static SM_StuDorms Fetch(System.Linq.Expressions.Expression<Func<SM_StuDorm, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<SM_StuDorm>(exp,values);
            return EF.DataPortal.Fetch<SM_StuDorms>(lambda);
		}

		public static SM_StuDorms Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<SM_StuDorms>(new Paging { Page=page,RowCount=rowCount});
        }

        public static SM_StuDorms Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<SM_StuDorm, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<SM_StuDorms>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<SM_StuDorm>(exp,values)});
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
