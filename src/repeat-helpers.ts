export class SortValueConverter {
    toView(array, propertyName, direction) {
        var factor = direction === 'ascending' ? 1 : -1;
        return array
            .slice(0)
            .sort((a, b) => {
                var nameA = a[propertyName].toUpperCase(); // ignore upper and lowercase
                var nameB = b[propertyName].toUpperCase(); // ignore upper and lowercase
                if (nameA < nameB) {
                    return -1 * factor;
                }
                if (nameA > nameB) {
                    return 1 * factor;
                }

                // names must be equal
                return 0;
            });
    }
}


export class TakeValueConverter {
    toView(array, count) {
        return array.slice(0, count);
    }
}