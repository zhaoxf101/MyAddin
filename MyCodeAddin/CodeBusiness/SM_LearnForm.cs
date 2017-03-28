using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(SM_LearnForm))]
#if Dev
    [RunLocal]
#endif

	public class SM_LearnForm:ReadOnlyBase<SM_LearnForm>
    {
        #region Business Methods

		
        public string LearnFormCode
        {
            get ;
            set ;
        }

		
        public string LearnFormName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static SM_LearnForm Create()
        {
            return EF.DataPortal.Create<SM_LearnForm>();
        }

		public static SM_LearnForm Fetch(System.Linq.Expressions.Expression<Func<SM_LearnForm, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<SM_LearnForm>(exp,values);
            return EF.DataPortal.Fetch<SM_LearnForm>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(SM_LearnForms))]
#if Dev
    [RunLocal]
#endif
	
	public class SM_LearnForms:ReadOnlyListBase<SM_LearnForms,SM_LearnForm>
    {
        #region Factory Methods

        public static SM_LearnForms Fetch()
        {
            return EF.DataPortal.Fetch<SM_LearnForms>();
        }

		public static SM_LearnForms Fetch(System.Linq.Expressions.Expression<Func<SM_LearnForm, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<SM_LearnForm>(exp,values);
            return EF.DataPortal.Fetch<SM_LearnForms>(lambda);
		}

		public static SM_LearnForms Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<SM_LearnForms>(new Paging { Page=page,RowCount=rowCount});
        }

        public static SM_LearnForms Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<SM_LearnForm, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<SM_LearnForms>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<SM_LearnForm>(exp,values)});
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
