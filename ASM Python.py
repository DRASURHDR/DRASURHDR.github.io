def calculate_gpa(subjects):
    total_credits = 0
    total_weighted_score = 0

    for subject in subjects:
        credit, grade = subject
        total_credits += credit
        total_weighted_score += credit * grade

    # Tránh chia cho 0 và làm tròn đến hai chữ số thập phân
    return round(total_weighted_score / total_credits, 2) if total_credits != 0 else 0.0

def main():
    subjects = []

    # Nhập thông tin cho mỗi môn học từ người dùng
    for subject_name in ["C#", "Java", "Python"]:
        while True:
            try:
                credit = int(input(f"Enter credits for {subject_name}: "))
                if credit > 0:
                    break
                else:
                    print("Invalid credits. Please enter a positive integer.")
            except ValueError:
                print("Invalid input. Please enter a valid number.")

        while True:
            try:
                grade = float(input(f"Enter grade for {subject_name}: "))
                if 0 <= grade <= 10:
                    break
                else:
                    print("Invalid grade. Please enter a value between 0 and 10.")
            except ValueError:
                print("Invalid input. Please enter a valid number.")

        subjects.append((credit, grade))

    gpa = calculate_gpa(subjects)
    print(f"\nCalculated GPA: {gpa}")

if __name__ == "__main__":
    main()
