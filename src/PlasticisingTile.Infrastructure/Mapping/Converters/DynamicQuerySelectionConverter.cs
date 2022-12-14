using AutoMapper;
using PlasticisingTile.Core.Models.DynamicQuery;
using Serenity.Data;

namespace PlasticisingTile.Infrastructure.Mapping.Converters;
internal class DynamicQuerySelectionConverter : ITypeConverter<IEnumerable<DynamicQuerySelection>, SqlQuery>
{
    public SqlQuery Convert(IEnumerable<DynamicQuerySelection> selections, SqlQuery sqlQuery, ResolutionContext context)
    {
        sqlQuery ??= new SqlQuery();

        if (selections != null && selections.Any())
        {
            BaseCriteria? criteria = null;
            var firstCriteria = true;

            foreach (var selection in selections)
            {
                var leftOperand = new Criteria(selection.LeftOperandAttributeKey);
                var rightOperand = new ValueCriteria(selection.RightOperandValue);

                var newCriteria = selection.Operation switch
                {
                    SelectionOperationEnum.LessThan => leftOperand < rightOperand,
                    SelectionOperationEnum.LessThanOrEqual => leftOperand <= rightOperand,
                    SelectionOperationEnum.GreaterThan => leftOperand > rightOperand,
                    SelectionOperationEnum.GreaterThanOrEqual => leftOperand >= rightOperand,
                    _ => throw new NotImplementedException()
                };

                if (firstCriteria)
                {
                    criteria = newCriteria;
                    firstCriteria = false;
                }
                else
                {
                    criteria &= newCriteria;
                }
            }

            sqlQuery = sqlQuery
                .Where(criteria);
        }

        return sqlQuery;
    }
}
