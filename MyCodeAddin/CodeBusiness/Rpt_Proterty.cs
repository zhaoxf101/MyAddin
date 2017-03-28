using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Rpt_Proterty))]
#if Dev
    [RunLocal]
#endif

	public class Rpt_Proterty:ReadOnlyBase<Rpt_Proterty>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string PropertyId
        {
            get ;
            set ;
        }

		
        public string PropertyName
        {
            get ;
            set ;
        }

		
        public string AccType
        {
            get ;
            set ;
        }

		
        public string TableName
        {
            get ;
            set ;
        }

		
        public string FieldName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static Rpt_Proterty Create()
        {
            return EF.DataPortal.Create<Rpt_Proterty>();
        }

		public static Rpt_Proterty Fetch(System.Linq.Expressions.Expression<Func<Rpt_Proterty, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Rpt_Proterty>(exp,values);
            return EF.DataPortal.Fetch<Rpt_Proterty>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Rpt_Protertys))]
#if Dev
    [RunLocal]
#endif
	
	public class Rpt_Protertys:ReadOnlyListBase<Rpt_Protertys,Rpt_Proterty>
    {
        #region Factory Methods

        public static Rpt_Protertys Fetch()
        {
            return EF.DataPortal.Fetch<Rpt_Protertys>();
        }

		public static Rpt_Protertys Fetch(System.Linq.Expressions.Expression<Func<Rpt_Proterty, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Rpt_Proterty>(exp,values);
            return EF.DataPortal.Fetch<Rpt_Protertys>(lambda);
		}

		public static Rpt_Protertys Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Rpt_Protertys>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Rpt_Protertys Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Rpt_Proterty, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Rpt_Protertys>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Rpt_Proterty>(exp,values)});
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
