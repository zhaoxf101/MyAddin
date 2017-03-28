using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Rpt_RepotItem))]
#if Dev
    [RunLocal]
#endif

	public class Rpt_RepotItem:ReadOnlyBase<Rpt_RepotItem>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string RepotCode
        {
            get ;
            set ;
        }

		
        public string ItemId
        {
            get ;
            set ;
        }

		
        public int? ColId
        {
            get ;
            set ;
        }

		
        public string ItemName
        {
            get ;
            set ;
        }

		
        public bool? IsValue
        {
            get ;
            set ;
        }

		
        public bool? IsSum
        {
            get ;
            set ;
        }

		
        public bool? IsView
        {
            get ;
            set ;
        }

		
        public string ParentId
        {
            get ;
            set ;
        }

		
        public int? RptLevel
        {
            get ;
            set ;
        }

		
        public string Sort
        {
            get ;
            set ;
        }

		
        public string VievItem
        {
            get ;
            set ;
        }

		
        public string SumType
        {
            get ;
            set ;
        }

		
        public string GetValueObjectName
        {
            get ;
            set ;
        }

		
        public bool? IsSyn
        {
            get ;
            set ;
        }

		
        public string GetItemObjectName
        {
            get ;
            set ;
        }

		
        public string AccType
        {
            get ;
            set ;
        }

		
        public string RuleId
        {
            get ;
            set ;
        }

		
        public bool? IsAmt1
        {
            get ;
            set ;
        }

		
        public bool? IsAmt2
        {
            get ;
            set ;
        }

		
        public bool? IsAmt3
        {
            get ;
            set ;
        }

		
        public bool? IsAmt4
        {
            get ;
            set ;
        }

		
        public bool? IsAmt5
        {
            get ;
            set ;
        }

		
        public bool? IsAmt6
        {
            get ;
            set ;
        }

		
        public bool? IsAmt7
        {
            get ;
            set ;
        }

		
        public bool? IsAmt8
        {
            get ;
            set ;
        }

		
        public bool? IsAmt9
        {
            get ;
            set ;
        }

		
        public bool? IsAmt10
        {
            get ;
            set ;
        }

		
        public bool? IsAmt11
        {
            get ;
            set ;
        }

		
        public bool? IsAmt12
        {
            get ;
            set ;
        }

		
        public bool? IsAmt13
        {
            get ;
            set ;
        }

		
        public bool? IsAmt14
        {
            get ;
            set ;
        }

		
        public string FunctionAmt1
        {
            get ;
            set ;
        }

		
        public string FunctionAmt2
        {
            get ;
            set ;
        }

		
        public string FunctionAmt3
        {
            get ;
            set ;
        }

		
        public string FunctionAmt4
        {
            get ;
            set ;
        }

		
        public string FunctionAmt5
        {
            get ;
            set ;
        }

		
        public string FunctionAmt6
        {
            get ;
            set ;
        }

		
        public string FunctionAmt7
        {
            get ;
            set ;
        }

		
        public string FunctionAmt8
        {
            get ;
            set ;
        }

		
        public string FunctionAmt9
        {
            get ;
            set ;
        }

		
        public string FunctionAmt10
        {
            get ;
            set ;
        }

		
        public string FunctionAmt11
        {
            get ;
            set ;
        }

		
        public string FunctionAmt12
        {
            get ;
            set ;
        }

		
        public string FunctionAmt13
        {
            get ;
            set ;
        }

		
        public string FunctionAmt14
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static Rpt_RepotItem Create()
        {
            return EF.DataPortal.Create<Rpt_RepotItem>();
        }

		public static Rpt_RepotItem Fetch(System.Linq.Expressions.Expression<Func<Rpt_RepotItem, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Rpt_RepotItem>(exp,values);
            return EF.DataPortal.Fetch<Rpt_RepotItem>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Rpt_RepotItems))]
#if Dev
    [RunLocal]
#endif
	
	public class Rpt_RepotItems:ReadOnlyListBase<Rpt_RepotItems,Rpt_RepotItem>
    {
        #region Factory Methods

        public static Rpt_RepotItems Fetch()
        {
            return EF.DataPortal.Fetch<Rpt_RepotItems>();
        }

		public static Rpt_RepotItems Fetch(System.Linq.Expressions.Expression<Func<Rpt_RepotItem, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Rpt_RepotItem>(exp,values);
            return EF.DataPortal.Fetch<Rpt_RepotItems>(lambda);
		}

		public static Rpt_RepotItems Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Rpt_RepotItems>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Rpt_RepotItems Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Rpt_RepotItem, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Rpt_RepotItems>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Rpt_RepotItem>(exp,values)});
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
