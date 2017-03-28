using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_ExpBusEtt))]
#if Dev
    [RunLocal]
#endif

	public class HR_ExpBusEtt:ReadOnlyBase<HR_ExpBusEtt>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string EttItemCode
        {
            get ;
            set ;
        }

		
        public string Period
        {
            get ;
            set ;
        }

		
        public string BillNo
        {
            get ;
            set ;
        }

		
        public string ExpBusCode
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_ExpBusEtt Create()
        {
            return EF.DataPortal.Create<HR_ExpBusEtt>();
        }

		public static HR_ExpBusEtt Fetch(System.Linq.Expressions.Expression<Func<HR_ExpBusEtt, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_ExpBusEtt>(exp,values);
            return EF.DataPortal.Fetch<HR_ExpBusEtt>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_ExpBusEtts))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_ExpBusEtts:ReadOnlyListBase<HR_ExpBusEtts,HR_ExpBusEtt>
    {
        #region Factory Methods

        public static HR_ExpBusEtts Fetch()
        {
            return EF.DataPortal.Fetch<HR_ExpBusEtts>();
        }

		public static HR_ExpBusEtts Fetch(System.Linq.Expressions.Expression<Func<HR_ExpBusEtt, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_ExpBusEtt>(exp,values);
            return EF.DataPortal.Fetch<HR_ExpBusEtts>(lambda);
		}

		public static HR_ExpBusEtts Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_ExpBusEtts>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_ExpBusEtts Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_ExpBusEtt, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_ExpBusEtts>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_ExpBusEtt>(exp,values)});
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
