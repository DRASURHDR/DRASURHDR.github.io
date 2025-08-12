package StudentManagement;

import java.util.ArrayList;
import java.util.Objects;

public class ArrayListRemoveStudent {
    public void removeStudentById(ArrayList<Student> students, String id){
        for (int i = 0; i < students.size(); i++) {
            if(Objects.equals(students.get(i).id, id)){
                students.remove(i);
            }
        }
    }
}






        int low = 0, high = list.size() - 1;
while (low <= high) {
int mid = (low + high) / 2;
int cmp = list.get(mid).getId().compareTo(targetId);
    if (cmp == 0) return list.get(mid);
    else if (cmp < 0) low = mid + 1;
        else high = mid - 1;
        }











