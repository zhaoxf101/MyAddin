using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Sys_Unit))]
#if Dev
    [RunLocal]
#endif

	public class Sys_Unit:ReadOnlyBase<Sys_Unit>
    {
        #region Business Methods

		
        public string UnitCode
        {
            get ;
            set ;
        }

		
        public string UnitGrp
        {
            get ;
            set ;
        }

		
        public string UnitName
        {
            get ;
            set ;
        }

		
        public string LText
        {
            get ;
            set ;
        }

		
        public string MSEHT
        {
            get ;
            set ;
        }

		
        public string MSEHE
        {
            get ;
            set ;
        }

		
        public bool Primy
        {
            get ;
            set ;
        }

		
        public int ZAEHL
        {
            get ;
            set ;
        }

		
        public int NENNR
        {
            get ;
            set ;
        }

		
        public bool Active
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

		public static Sys_Unit Create()
        {
            return EF.DataPortal.Create<Sys_Unit>();
        }

		public static Sys_Unit Fetch(System.Linq.Expressions.Expression<Func<Sys_Unit, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Sys_Unit>(exp,values);
            return EF.DataPortal.Fetch<Sys_Unit>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Sys_Units))]
#if Dev
    [RunLocal]
#endif
	
	public class Sys_Units:ReadOnlyListBase<Sys_Units,Sys_Unit>
    {
        #region Factory Methods

        public static Sys_Units Fetch()
        {
            return EF.DataPortal.Fetch<Sys_Units>();
        }

		public static Sys_Units Fetch(System.Linq.Expressions.Expression<Func<Sys_Unit, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Sys_Unit>(exp,values);
            return EF.DataPortal.Fetch<Sys_Units>(lambda);
		}

		public static Sys_Units Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Sys_Units>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Sys_Units Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Sys_Unit, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Sys_Units>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Sys_Unit>(exp,values)});
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
