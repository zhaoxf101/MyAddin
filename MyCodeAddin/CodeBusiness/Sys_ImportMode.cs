using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Sys_ImportMode))]
#if Dev
    [RunLocal]
#endif

	public class Sys_ImportMode:ReadOnlyBase<Sys_ImportMode>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ModeCode
        {
            get ;
            set ;
        }

		
        public string ModeText
        {
            get ;
            set ;
        }

		
        public string BusType
        {
            get ;
            set ;
        }

		
        public string GetAreaCode
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

		public static Sys_ImportMode Create()
        {
            return EF.DataPortal.Create<Sys_ImportMode>();
        }

		public static Sys_ImportMode Fetch(System.Linq.Expressions.Expression<Func<Sys_ImportMode, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Sys_ImportMode>(exp,values);
            return EF.DataPortal.Fetch<Sys_ImportMode>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Sys_ImportModes))]
#if Dev
    [RunLocal]
#endif
	
	public class Sys_ImportModes:ReadOnlyListBase<Sys_ImportModes,Sys_ImportMode>
    {
        #region Factory Methods

        public static Sys_ImportModes Fetch()
        {
            return EF.DataPortal.Fetch<Sys_ImportModes>();
        }

		public static Sys_ImportModes Fetch(System.Linq.Expressions.Expression<Func<Sys_ImportMode, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Sys_ImportMode>(exp,values);
            return EF.DataPortal.Fetch<Sys_ImportModes>(lambda);
		}

		public static Sys_ImportModes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Sys_ImportModes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Sys_ImportModes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Sys_ImportMode, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Sys_ImportModes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Sys_ImportMode>(exp,values)});
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
