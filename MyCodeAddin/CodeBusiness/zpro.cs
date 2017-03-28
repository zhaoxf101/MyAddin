using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(zpro))]
#if Dev
    [RunLocal]
#endif

	public class zpro:ReadOnlyBase<zpro>
    {
        #region Business Methods

		
        public int? xh
        {
            get ;
            set ;
        }

		
        public string pcode
        {
            get ;
            set ;
        }

		
        public string pname
        {
            get ;
            set ;
        }

		
        public string projfund
        {
            get ;
            set ;
        }

		
        public string typepcode
        {
            get ;
            set ;
        }

		
        public string mcode
        {
            get ;
            set ;
        }

		
        public string lperno
        {
            get ;
            set ;
        }

		
        public string dcode
        {
            get ;
            set ;
        }

		
        public string dposicode
        {
            get ;
            set ;
        }

		
        public string cldcode
        {
            get ;
            set ;
        }

		
        public string clposicode
        {
            get ;
            set ;
        }

		
        public string sclposicode
        {
            get ;
            set ;
        }

		
        public string projmem
        {
            get ;
            set ;
        }

		
        public string con
        {
            get ;
            set ;
        }

		
        public bool? isbud
        {
            get ;
            set ;
        }

		
        public bool? isfin
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static zpro Create()
        {
            return EF.DataPortal.Create<zpro>();
        }

		public static zpro Fetch(System.Linq.Expressions.Expression<Func<zpro, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<zpro>(exp,values);
            return EF.DataPortal.Fetch<zpro>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(zpros))]
#if Dev
    [RunLocal]
#endif
	
	public class zpros:ReadOnlyListBase<zpros,zpro>
    {
        #region Factory Methods

        public static zpros Fetch()
        {
            return EF.DataPortal.Fetch<zpros>();
        }

		public static zpros Fetch(System.Linq.Expressions.Expression<Func<zpro, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<zpro>(exp,values);
            return EF.DataPortal.Fetch<zpros>(lambda);
		}

		public static zpros Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<zpros>(new Paging { Page=page,RowCount=rowCount});
        }

        public static zpros Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<zpro, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<zpros>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<zpro>(exp,values)});
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
