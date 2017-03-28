using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_EmpRelation))]
#if Dev
    [RunLocal]
#endif

	public class HR_EmpRelation:ReadOnlyBase<HR_EmpRelation>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public Guid Id
        {
            get ;
            set ;
        }

		
        public string EmpCode
        {
            get ;
            set ;
        }

		
        public string RelationCode
        {
            get ;
            set ;
        }

		
        public string RelationValue
        {
            get ;
            set ;
        }

		
        public string StartDate
        {
            get ;
            set ;
        }

		
        public string EndDate
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
        public bool IsDel
        {
            get ;
            set ;
        }

		
        public DateTime? CreateDate
        {
            get ;
            set ;
        }

		
        public string CreateUser
        {
            get ;
            set ;
        }

		
        public DateTime? ChangeDate
        {
            get ;
            set ;
        }

		
        public string ChangeUser
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_EmpRelation Create()
        {
            return EF.DataPortal.Create<HR_EmpRelation>();
        }

		public static HR_EmpRelation Fetch(System.Linq.Expressions.Expression<Func<HR_EmpRelation, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpRelation>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpRelation>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_EmpRelations))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_EmpRelations:ReadOnlyListBase<HR_EmpRelations,HR_EmpRelation>
    {
        #region Factory Methods

        public static HR_EmpRelations Fetch()
        {
            return EF.DataPortal.Fetch<HR_EmpRelations>();
        }

		public static HR_EmpRelations Fetch(System.Linq.Expressions.Expression<Func<HR_EmpRelation, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpRelation>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpRelations>(lambda);
		}

		public static HR_EmpRelations Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_EmpRelations>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_EmpRelations Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_EmpRelation, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_EmpRelations>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_EmpRelation>(exp,values)});
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
