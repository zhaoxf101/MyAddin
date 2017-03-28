using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(UP_Area))]
#if Dev
    [RunLocal]
#endif

	public class UP_Area:ReadOnlyBase<UP_Area>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public Guid Id
        {
            get ;
            set ;
        }

		
        public string AreaCode
        {
            get ;
            set ;
        }

		
        public string AreaName
        {
            get ;
            set ;
        }

		
        public string Remark
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

		public static UP_Area Create()
        {
            return EF.DataPortal.Create<UP_Area>();
        }

		public static UP_Area Fetch(System.Linq.Expressions.Expression<Func<UP_Area, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<UP_Area>(exp,values);
            return EF.DataPortal.Fetch<UP_Area>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(UP_Areas))]
#if Dev
    [RunLocal]
#endif
	
	public class UP_Areas:ReadOnlyListBase<UP_Areas,UP_Area>
    {
        #region Factory Methods

        public static UP_Areas Fetch()
        {
            return EF.DataPortal.Fetch<UP_Areas>();
        }

		public static UP_Areas Fetch(System.Linq.Expressions.Expression<Func<UP_Area, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<UP_Area>(exp,values);
            return EF.DataPortal.Fetch<UP_Areas>(lambda);
		}

		public static UP_Areas Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<UP_Areas>(new Paging { Page=page,RowCount=rowCount});
        }

        public static UP_Areas Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<UP_Area, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<UP_Areas>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<UP_Area>(exp,values)});
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
