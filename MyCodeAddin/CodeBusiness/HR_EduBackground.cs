using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_EduBackground))]
#if Dev
    [RunLocal]
#endif

	public class HR_EduBackground:ReadOnlyBase<HR_EduBackground>
    {
        #region Business Methods

		
        public string EduBackground
        {
            get ;
            set ;
        }

		
        public string EduBackgroundName
        {
            get ;
            set ;
        }

		
        public bool Flag
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_EduBackground Create()
        {
            return EF.DataPortal.Create<HR_EduBackground>();
        }

		public static HR_EduBackground Fetch(System.Linq.Expressions.Expression<Func<HR_EduBackground, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_EduBackground>(exp,values);
            return EF.DataPortal.Fetch<HR_EduBackground>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_EduBackgrounds))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_EduBackgrounds:ReadOnlyListBase<HR_EduBackgrounds,HR_EduBackground>
    {
        #region Factory Methods

        public static HR_EduBackgrounds Fetch()
        {
            return EF.DataPortal.Fetch<HR_EduBackgrounds>();
        }

		public static HR_EduBackgrounds Fetch(System.Linq.Expressions.Expression<Func<HR_EduBackground, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_EduBackground>(exp,values);
            return EF.DataPortal.Fetch<HR_EduBackgrounds>(lambda);
		}

		public static HR_EduBackgrounds Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_EduBackgrounds>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_EduBackgrounds Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_EduBackground, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_EduBackgrounds>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_EduBackground>(exp,values)});
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
