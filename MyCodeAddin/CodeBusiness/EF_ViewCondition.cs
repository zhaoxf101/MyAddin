using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_ViewCondition))]
#if Dev
    [RunLocal]
#endif

	public class EF_ViewCondition:ReadOnlyBase<EF_ViewCondition>
    {
        #region Business Methods

		
        public string ViewName
        {
            get ;
            set ;
        }

		
        public string RowStatus
        {
            get ;
            set ;
        }

		
        public int Position
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

		
        public string Negation
        {
            get ;
            set ;
        }

		
        public string Operator
        {
            get ;
            set ;
        }

		
        public string Constants
        {
            get ;
            set ;
        }

		
        public string AndOr
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static EF_ViewCondition Create()
        {
            return EF.DataPortal.Create<EF_ViewCondition>();
        }

		public static EF_ViewCondition Fetch(System.Linq.Expressions.Expression<Func<EF_ViewCondition, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_ViewCondition>(exp,values);
            return EF.DataPortal.Fetch<EF_ViewCondition>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_ViewConditions))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_ViewConditions:ReadOnlyListBase<EF_ViewConditions,EF_ViewCondition>
    {
        #region Factory Methods

        public static EF_ViewConditions Fetch()
        {
            return EF.DataPortal.Fetch<EF_ViewConditions>();
        }

		public static EF_ViewConditions Fetch(System.Linq.Expressions.Expression<Func<EF_ViewCondition, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_ViewCondition>(exp,values);
            return EF.DataPortal.Fetch<EF_ViewConditions>(lambda);
		}

		public static EF_ViewConditions Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_ViewConditions>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_ViewConditions Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_ViewCondition, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_ViewConditions>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_ViewCondition>(exp,values)});
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
