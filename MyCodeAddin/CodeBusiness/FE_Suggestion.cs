using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FE_Suggestion))]
#if Dev
    [RunLocal]
#endif

	public class FE_Suggestion:ReadOnlyBase<FE_Suggestion>
    {
        #region Business Methods

		
        public int SuggestionId
        {
            get ;
            set ;
        }

		
        public string OpenId
        {
            get ;
            set ;
        }

		
        public string PersonName
        {
            get ;
            set ;
        }

		
        public string Tel
        {
            get ;
            set ;
        }

		
        public string Email
        {
            get ;
            set ;
        }

		
        public string SuggestText
        {
            get ;
            set ;
        }

		
        public DateTime? SuggestDateTime
        {
            get ;
            set ;
        }

		
        public bool IsReaded
        {
            get ;
            set ;
        }

		
        public bool IsReplyed
        {
            get ;
            set ;
        }

		
        public string ReplyText
        {
            get ;
            set ;
        }

		
        public DateTime? ReplyDateTime
        {
            get ;
            set ;
        }

		
        public bool IsClose
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FE_Suggestion Create()
        {
            return EF.DataPortal.Create<FE_Suggestion>();
        }

		public static FE_Suggestion Fetch(System.Linq.Expressions.Expression<Func<FE_Suggestion, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FE_Suggestion>(exp,values);
            return EF.DataPortal.Fetch<FE_Suggestion>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FE_Suggestions))]
#if Dev
    [RunLocal]
#endif
	
	public class FE_Suggestions:ReadOnlyListBase<FE_Suggestions,FE_Suggestion>
    {
        #region Factory Methods

        public static FE_Suggestions Fetch()
        {
            return EF.DataPortal.Fetch<FE_Suggestions>();
        }

		public static FE_Suggestions Fetch(System.Linq.Expressions.Expression<Func<FE_Suggestion, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FE_Suggestion>(exp,values);
            return EF.DataPortal.Fetch<FE_Suggestions>(lambda);
		}

		public static FE_Suggestions Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FE_Suggestions>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FE_Suggestions Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FE_Suggestion, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FE_Suggestions>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FE_Suggestion>(exp,values)});
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
